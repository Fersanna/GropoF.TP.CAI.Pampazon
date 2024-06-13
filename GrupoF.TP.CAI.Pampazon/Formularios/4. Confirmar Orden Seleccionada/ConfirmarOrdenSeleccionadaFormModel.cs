using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    internal class ConfirmarOrdenSeleccionadaFormModel
    {
        public List<OrdenDeSeleccionada> OrdenEnSeleccion { get; set; }
        //Seguir x aca
        public ConfirmarOrdenSeleccionadaFormModel()
        {
            var ordenesAconfirmar = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts;


            if (ordenesAconfirmar != null)
            {
                var ordenesEnSeleccion = ordenesAconfirmar.FindAll(p => p.EstadoOrden == Entidades.Estados.Estado.Seleccion);

                OrdenEnSeleccion = ordenesEnSeleccion.Select(ordenEnt =>
                new OrdenDeSeleccionada
                {
                     NumeroDeOrden = ordenEnt.NumeroDeOrden,
                     Fecha = ordenEnt.Fecha,
                     CodigoCliente = ordenEnt.CodigoCliente,
                     CodigoTransportista = ordenEnt.CodigoTransportista,
                     Estado = ordenEnt.EstadoOrden,
                    
                }).ToList();
            }
        }

        //internal void CambiarEstadoEnOrden(OrdenDeSeleccion orden)
        //{
        //   if (orden.EstadoOrden != "En selección")
        //    {
        //        MessageBox.Show("Esta Orden ya ha sido seleccionada");
        //    }
        //   else
        //    {
        //        orden.EstadoOrden = "Seleccionada";
        //        return;
        //    }

        //}
    }
}
