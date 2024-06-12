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
        public  ConfirmarOrdenSeleccionadaFormModel()
        {
            var ordenesAconfirmar = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt;
           
            if (ordenesAconfirmar != null)
            {
                OrdenEnSeleccion = ordenesAconfirmar.Select(ordenEnt =>
                new OrdenDeSeleccionada
                {
                    NumeroDeOrden = ordenEnt.IdOrdenDeSeleccion,
                    Estado =ordenEnt.Estado,
                    OrdenesSeleccionadas = ordenEnt.SeleccionDetalle.Select(detalle => detalle.NumeroDeOrden).ToList(),
                    
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
