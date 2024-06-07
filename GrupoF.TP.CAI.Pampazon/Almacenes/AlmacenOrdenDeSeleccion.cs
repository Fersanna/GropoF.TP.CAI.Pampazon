using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    internal class AlmacenOrdenDeSeleccion
    {
        public readonly static List<OrdenDeSeleccionEnt> OrdenesDeSeleccionEnt;
        public static OrdenDeSeleccionEnt OrdenesDeSeleccion { get; internal set; }

        static AlmacenOrdenDeSeleccion()
        {
            OrdenesDeSeleccionEnt = new List<OrdenDeSeleccionEnt>();

            try
            {
                if (File.Exists("OrdenesDePreparacion.Json"))
                {
                    var archivoCargado = File.ReadAllText("OrdenesDePreparacion.Json");
                    OrdenesDeSeleccionEnt = JsonConvert.DeserializeObject<List<OrdenDeSeleccionEnt>>(archivoCargado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las órdenes de preparación: {ex.Message}");
            }
        }

        public static void Grabar()
        {
            var contenidoJson = JsonConvert.SerializeObject(OrdenesDeSeleccionEnt);

            // Guardar en el archivo
            File.WriteAllText("OrdenesDePreparacion.Json", contenidoJson);
        }

        internal static void AgregarOrden(OrdenDeSeleccionEnt ordenEnt)
        {
           
            OrdenesDeSeleccion = ordenEnt;
            MessageBox.Show($"El número de orden guardada: {ordenEnt.IdOrdenDeSeleccion}");
        }
    }
}