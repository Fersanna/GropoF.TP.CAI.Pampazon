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
                OrdenesSeleccionPendientes = ordenesDeSeleccion
                                                .Select(ordenEnt => new OrdenDeSeleccionPendiente
                                                                      {
                                                                          IdOrdenDeSeleccion = ordenEnt.IdOrdenDeSeleccion,
                                                                          EstadoOrdenSeleccion = ordenEnt.EstadoOrdenSeleccion,
                                                                          SeleccionDetalle = ordenEnt.SeleccionDetalle.Select(d => d.NumeroDeOrden).ToList()
                                                                      })
                                                .ToList();
            }
            else
            {
                MessageBox.Show("Debe ingresar una orden de selección");
            }
        }

        internal string Confirmar()
        {
            //TODO: verificar que haya stock? 
            //TODO: bajar el stock
            //TODO: Recargar la lista OrdenesSeleccionPendientes.



            OrdenDeSeleccionElegida = null;
            //si hay algun error string con mensaje para el usuario, si no devolver null
            return null;
        }
    }
}


