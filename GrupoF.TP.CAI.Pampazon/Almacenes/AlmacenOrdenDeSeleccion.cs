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
            try
            {
                var contenidoJson = JsonConvert.SerializeObject(OrdenesDeSeleccionEnt, Formatting.Indented);
                File.WriteAllText(@"Json\OrdenesDeSeleccion.json", contenidoJson);
                MessageBox.Show("La orden de selección fue generada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las órdenes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        internal static void AgregarOrden(OrdenDeSeleccionEnt ordenEnt)
        {

            ordenEnt.IdOrdenDeSeleccion = contadorOrdenes.ToString();
            contadorOrdenes++;
            ordenEnt.EstadoOrdenSeleccion = EstadoSeleccionEnum.EstadoSeleccion.Pendiente;
            OrdenesDeSeleccionEnt.Add(ordenEnt);
            MessageBox.Show($"El número de orden guardada: {ordenEnt.IdOrdenDeSeleccion}");
            Grabar();
        }

        public static void CambiarEstadoOrdenSeleecion (OrdenDeSeleccionPendiente ordenDeSeleccionPendiente )
        {
            if (ordenDeSeleccionPendiente.EstadoOrdenSeleccion == EstadoSeleccionEnum.EstadoSeleccion.Pendiente)
            {
                ordenDeSeleccionPendiente.EstadoOrdenSeleccion = EstadoSeleccionEnum.EstadoSeleccion.Cumplida;
            }

        }
    }
}