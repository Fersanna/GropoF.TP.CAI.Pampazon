using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos.Clases_Auxiliares_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public class GenerarRemitosModel
    {
        public OrdenDeEntregaPendiente OrdenSeleccionada { get; internal set; }
        public List<OrdenDeEntregaPendiente> OrdenesDeEntrega { get; set; } = new List<OrdenDeEntregaPendiente>();


        public GenerarRemitosModel()
        {
            var ordenesDeEntrega = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts;

            if (ordenesDeEntrega != null)
            {
                OrdenesDeEntrega = ordenesDeEntrega
                                                .Select(ordenEnt => new OrdenDeEntregaPendiente
                                                {
                                                    IdOrdenDeEntrega = ordenEnt.IdOrdenDeEntrega,
                                                    CodigoCliente = ordenEnt.CodigoCliente,
                                                    Fecha = ordenEnt.Fecha,
                                                    CodigoTransportista = ordenEnt.CodigoTransportista,
                                                    EstadoOrdenEntrega = ordenEnt.EstadoOrdenEntrega,
                                                    EntregaDetalle = ordenEnt.EntregaDetalle.Select(d => d.NumeroDeOrden).ToList()
                                                })
                                                .ToList();
            }
            else
            {
                MessageBox.Show("Debe ingresar una orden de selección");
            }


            /*
            
            OrdenesDeEntrega = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts.Select(ordenEnt => new OrdenDeEntregaPendiente
            {
                IdOrdenDeEntrega = ordenEnt.IdOrdenDeEntrega,
                Fecha = ordenEnt.Fecha,
               // EstadoOrden = ordenEnt.EstadoEntrega,
               //Hay que hacer una nueva clase auxiliar 
            }
              ).ToList();

            */
        }

        internal void CambiarEstadoOrdenSeleccionada()
        {
            var ordenSeleccionada = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts.FirstOrDefault(o => OrdenSeleccionada.IdOrdenDeEntrega == o.IdOrdenDeEntrega  );

            ordenSeleccionada.EstadoOrdenEntrega = Entidades.EstadoEntregaEnum.EstadoEntrega.Asignado;
        }

        internal void GuardarRemito()
        {
            throw new NotImplementedException();
        }
    }
}
