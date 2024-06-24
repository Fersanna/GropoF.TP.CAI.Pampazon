using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    public static class AlmacenOrdenesDePreparacion
    {
        public static List<OrdenDePreparacionEnt> OrdenDePreparacion; //lo que levantas del archivo.

        static AlmacenOrdenesDePreparacion()
        {
            OrdenDePreparacion = new List<OrdenDePreparacionEnt>();

            try
            {
                if (File.Exists(@"Json/OrdenesDePreparacion.Json"))
                {
                    var archivoCargado = File.ReadAllText(@"Json/OrdenesDePreparacion.Json");
                    OrdenDePreparacion = JsonConvert.DeserializeObject<List<OrdenDePreparacionEnt>>(archivoCargado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las órdenes de preparación: {ex.Message}");
            }
        }

        public static void Grabar()
        {
            var contenidoJson = JsonConvert.SerializeObject(OrdenDePreparacion, Newtonsoft.Json.Formatting.Indented);

            // Guardar en el archivo
            File.WriteAllText(@"json/OrdenesDePreparacion.Json", contenidoJson);
        }

        internal static void AgregarOrden(OrdenDePreparacionEnt ordenDePreparacionEnt)
        {
            if (OrdenDePreparacion == null)
            {
                OrdenDePreparacion = new List<OrdenDePreparacionEnt>();
            }


            var maxNumeroDeOrden = OrdenDePreparacion.Max(n => int.Parse(n.NumeroDeOrden));
            ordenDePreparacionEnt.NumeroDeOrden = (maxNumeroDeOrden + 1).ToString();;
            OrdenDePreparacion.Add(ordenDePreparacionEnt);

            /*
            var ultimaOrden = OrdenDePreparacionEnts.LastOrDefault();
            if (ultimaOrden != null)
            {
                MessageBox.Show($"La orden grabada en la lista es la número: {ultimaOrden.NumeroDeOrden}\n" +
                                $"Código Cliente: {ultimaOrden.CodigoCliente}\n" +
                                $"Fecha: {ultimaOrden.Fecha.ToString("dd/MM/yyyy")}\n" +
                                $"Transportista: {ultimaOrden.CodigoTransportista}\n" +
                                $"Prioridad: {(int)ultimaOrden.Prioridad}\n" +
                                $"Estado: {ultimaOrden.EstadoOrden}");
            }
            Grabar();*/
        }

        internal static void ModificarEstadoEnOrdenes(List<OrdenDeSeleccionDetalle> seleccionDetalle)
        {
            foreach (var detalle in seleccionDetalle)
            {
                var ordenDePreparacion = OrdenDePreparacion
                    .FirstOrDefault(o => o.NumeroDeOrden == detalle.NumeroDeOrden);

                if (ordenDePreparacion != null)
                {
                    ordenDePreparacion.EstadoOrden = EstadoPreparacion.Seleccion;
                }

            }
        }
    }
}
