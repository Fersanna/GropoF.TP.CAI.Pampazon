using GrupoF.TP.CAI.Pampazon.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    internal class ConfirmarOrdenSeleccionadaFormModel
    {
        public List<OrdenDePreparacionEnSeleccion> OrdenEnSeleccion { get; set; }

        public List<OrdenDePreparacionEnSeleccion> OrdenesSeleccionadas { get; set; }
        //Seguir x aca
        public ConfirmarOrdenSeleccionadaFormModel()
        {
            var ordenesAconfirmar = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts;


            if (ordenesAconfirmar != null)
            {
                var ordenesEnSeleccion = ordenesAconfirmar.FindAll(p => p.EstadoOrden == Entidades.Estados.Estado.Seleccion);

                OrdenEnSeleccion = ordenesEnSeleccion.Select(ordenEnt =>
                new OrdenDePreparacionEnSeleccion
                {
                    NumeroDeOrden = ordenEnt.NumeroDeOrden,
                    CodigoCliente = ordenEnt.CodigoCliente,
                    Fecha = ordenEnt.Fecha,
                    CodigoTransportista = ordenEnt.CodigoTransportista,
                    Prioridad = ordenEnt.Prioridad,
                    EstadoOrden = ordenEnt.EstadoOrden,

                }).ToList();
            }
        }

        internal void CambiarEstadoEnOrden(OrdenDePreparacionEnSeleccion ordenDePreparacion)
        {
            var orden = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts.FirstOrDefault(OrdenEnt => OrdenEnt.NumeroDeOrden == ordenDePreparacion.NumeroDeOrden);

            if (orden != null)

            {
                orden.EstadoOrden = Entidades.Estados.Estado.Seleccionada;

                var ordenEnSeleccion = OrdenEnSeleccion.FirstOrDefault(o => o.NumeroDeOrden == ordenDePreparacion.NumeroDeOrden);
                if (ordenEnSeleccion != null)
                {
                    ordenEnSeleccion.EstadoOrden = Entidades.Estados.Estado.Seleccionada;
                }
                
                if (OrdenesSeleccionadas == null)
                {
                    OrdenesSeleccionadas = new List<OrdenDePreparacionEnSeleccion>();
                }

                if (!OrdenesSeleccionadas.Contains(ordenDePreparacion))
                {
                    OrdenEnSeleccion.Remove(ordenDePreparacion);
                    OrdenesSeleccionadas.Add(ordenDePreparacion);
                }
                AlmacenOrdenesDePreparacion.Grabar();
            }

            else
            {

                throw new Exception("Orden no encontrada.");
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
