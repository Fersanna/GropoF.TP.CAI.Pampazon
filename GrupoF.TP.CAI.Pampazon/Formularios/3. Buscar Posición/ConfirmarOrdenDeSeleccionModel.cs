using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    public class ConfirmarOrdenDeSeleccionModel
    {
        public List<OrdenDeSeleccionPendiente> OrdenesSeleccionPendientes { get; set; } = new List<OrdenDeSeleccionPendiente>();

        public List<Productos> Productos { get; set; } = new List<Productos>();
        public OrdenDeSeleccionPendiente OrdenDeSeleccionElegida { get; internal set; }

        public ConfirmarOrdenDeSeleccionModel()
        {
            var ordenesDeSeleccion = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt;

            if (ordenesDeSeleccion != null)
            {
                OrdenesSeleccionPendientes = ordenesDeSeleccion.Select(ordenesEnt =>
                    new OrdenDeSeleccionPendiente
                    {
                        IdOrdenDeSeleccion = ordenesEnt.IdOrdenDeSeleccion,
                        EstadoOrdenSeleccion = ordenesEnt.EstadoOrdenSeleccion,
                    }).ToList();
            }
            else
            {
                MessageBox.Show("Debe ingresar una orden de selección");
            }
        }
    }
}


