using GrupoF.TP.CAI.Pampazon.Almacenes;

namespace GrupoF.TP.CAI.Pampazon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuForm());

            //esto pasa sólo si el sistema se cierra sin error.
            AlmacenClientes.Grabar();
            AlmacenOrdenDeEntrega.Grabar();
            AlmacenOrdenDeSeleccion.Grabar();
            AlmacenOrdenesDePreparacion.Grabar();
            AlmacenProductos.Grabar();
            AlmacenRemitos.Grabar();
        }
    }
}
