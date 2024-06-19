using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    internal class AlmacenOrdenDeEntrega
    {
        private static int contadorOrdenes = 0;
        public static List<OrdenDeEntregaEnt> OrdenDeEntregaEnts;

        static AlmacenOrdenDeEntrega()
        {
            OrdenDeEntregaEnts = new List<OrdenDeEntregaEnt>();

            try
            {
                if (File.Exists(@"Json/OrdenesDeEntrega.Json"))
                {
                    var archivoCargado = File.ReadAllText(@"Json/OrdenesDeEntrega.Json");
                    OrdenDeEntregaEnts = JsonConvert.DeserializeObject<List<OrdenDeEntregaEnt>>(archivoCargado);

                    var ultimoNumeroOrden = OrdenDeEntregaEnts.Max(o => int.Parse(o.IdOrdenDeEntrega));
                    contadorOrdenes = ultimoNumeroOrden + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las órdenes de preparación: {ex.Message}");
            }
        }

         public static void Grabar()
            {
                var contenidoJson = JsonConvert.SerializeObject(OrdenDeEntregaEnts, Newtonsoft.Json.Formatting.Indented);

                // Guardar en el archivo
                File.WriteAllText(@"json/OrdenesDeEntrega.Json", contenidoJson);
            }
    }
}
