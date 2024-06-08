using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    public static class AlmacenOrdenDeSeleccion
    {
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las órdenes de selección: {ex.Message}");
            }
        }

        public static void Grabar()
        {
            try
            {
                var contenidoJson = JsonConvert.SerializeObject(OrdenesDeSeleccionEnt, Formatting.Indented);
                File.WriteAllText(@"Json\OrdenesDeSeleccion.json", contenidoJson);
                MessageBox.Show("Órdenes guardadas correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las órdenes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        internal static void AgregarOrden(OrdenDeSeleccionEnt ordenEnt)
        {

            OrdenesDeSeleccionEnt.Add(ordenEnt);
            MessageBox.Show($"El número de orden guardada: {ordenEnt.IdOrdenDeSeleccion}");
            Grabar();
        }
    }
}