using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using Newtonsoft.Json;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    public static class AlmacenOrdenDeSeleccion
    {
        private static int contadorOrdenes = 0;
        public static List<OrdenDeSeleccionEnt> OrdenesDeSeleccionEnt { get; private set; }


        static AlmacenOrdenDeSeleccion()
        {
            OrdenesDeSeleccionEnt = new List<OrdenDeSeleccionEnt>();

            try
            {
                if (File.Exists(@"Json\OrdenesDeSeleccion.json"))
                {
                    var archivoCargado = File.ReadAllText(@"Json\OrdenesDeSeleccion.json");
                    var ordenes = JsonConvert.DeserializeObject<List<OrdenDeSeleccionEnt>>(archivoCargado);
                    if (ordenes != null)
                    {
                        OrdenesDeSeleccionEnt = ordenes;
                    }

                    if (OrdenesDeSeleccionEnt.Any())
                    {
                        var ultimoNumeroOrden = OrdenesDeSeleccionEnt.Max(o => int.Parse(o.IdOrdenDeSeleccion));
                        contadorOrdenes = ultimoNumeroOrden + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las órdenes de selección: {ex.Message}");
            }
        }

        public static void Grabar()
        {
            var contenidoJson = JsonConvert.SerializeObject(OrdenesDeSeleccionEnt, Formatting.Indented);
            File.WriteAllText(@"Json\OrdenesDeSeleccion.json", contenidoJson);
        }

        internal static void AgregarOrden(OrdenDeSeleccionEnt ordenEnt)
        {
            ordenEnt.IdOrdenDeSeleccion = contadorOrdenes.ToString();
            contadorOrdenes++;
            ordenEnt.EstadoOrdenSeleccion = EstadoSeleccion.Pendiente;
            OrdenesDeSeleccionEnt.Add(ordenEnt);
            Grabar();
        }

        public static void CambiarEstadoOrdenSeleccion(string ordenId, EstadoSeleccion estado)
        {
            var orden = OrdenesDeSeleccionEnt.Where(o => o.IdOrdenDeSeleccion == ordenId).First();
            orden.EstadoOrdenSeleccion = estado;
        }

    }
}