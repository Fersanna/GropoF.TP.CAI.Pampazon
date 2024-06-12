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
        public readonly static List<OrdenDePreparacionEnt> OrdenesDePreparacion;

        public static List<OrdenDePreparacionEnt> OrdenDePreparacionEnts;

        static AlmacenOrdenesDePreparacion()
        {
            OrdenesDePreparacion = new List<OrdenDePreparacionEnt>();

            try
            {
                if (File.Exists(@"Json/OrdenesDePreparacion.Json"))
                {
                    var archivoCargado = File.ReadAllText(@"Json/OrdenesDePreparacion.Json");
                    OrdenesDePreparacion = JsonConvert.DeserializeObject<List<OrdenDePreparacionEnt>>(archivoCargado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las órdenes de preparación: {ex.Message}");
            }
        }

        public static void Grabar()
        {
            var contenidoJson = JsonConvert.SerializeObject(OrdenDePreparacionEnts, Newtonsoft.Json.Formatting.Indented);

            // Guardar en el archivo
            File.WriteAllText(@"json/OrdenesDePreparacion.Json", contenidoJson);
        }

        internal static void AgregarOrden(OrdenDePreparacionEnt ordenDePreparacionEnt)
        {
            if (OrdenDePreparacionEnts == null)
            {
                OrdenDePreparacionEnts = new List<OrdenDePreparacionEnt>();
            }
            OrdenDePreparacionEnts.Add(ordenDePreparacionEnt);
            Grabar();
            var ultimaOrden = OrdenDePreparacionEnts.LastOrDefault();
            if (ultimaOrden != null)
            {
                MessageBox.Show($"La orden grabada en la lista es la número: {ultimaOrden.NumeroDeOrden}\n" +
                                $"Código Cliente: {ultimaOrden.CodigoCliente}\n" +
                                $"Fecha: {ultimaOrden.Fecha}\n" +
                                $"Transportista: {ultimaOrden.CodigoTransportista}\n" +
                                $"Estado: {ultimaOrden.EstadoOrden}");
            }
            Grabar();
        }

        internal static void ModificarEstadoEnOrdenes(List<OrdenDeSeleccionDetalle> seleccionDetalle)
        {
            foreach (var detalle in seleccionDetalle)
            {
                var ordenDePreparacion = OrdenDePreparacionEnts
                    .FirstOrDefault(o => o.NumeroDeOrden == detalle.NumeroDeOrden);

                if (ordenDePreparacion != null)
                {
                    ordenDePreparacion.EstadoOrden = Estados.Estado.Seleccion;
                }

            }
        }
    }
}
