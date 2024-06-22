using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega
{
    public class ConfirmarOrdenDeEntregaModel
    {
        public List<OrdenDePreparacionPreparada> OrdenesDeEntregaAConfirmar { get; set; }
        public OrdenDePreparacionPreparada OrdenADespachada { get; internal set; }


        public ConfirmarOrdenDeEntregaModel()
        {
            var ordenesAdespachar = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts;


            if (ordenesAdespachar != null)
            {
                var ordenesPreparadas = ordenesAdespachar.FindAll(p => p.EstadoOrden == Entidades.Estados.Estado.Preparada);

                OrdenesDeEntregaAConfirmar = ordenesPreparadas.Select(ordenEnt =>
                new OrdenDePreparacionPreparada
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
    }
}
