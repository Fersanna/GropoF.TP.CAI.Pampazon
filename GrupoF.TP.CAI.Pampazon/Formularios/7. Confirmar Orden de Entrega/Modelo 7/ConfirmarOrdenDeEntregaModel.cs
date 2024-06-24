using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_Auxiliares_7;
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

        public List<OrdenDePreparacionDespachada> OrdenesDeEntregaAEntregar { get; set; }
        public OrdenDePreparacionDespachada OrdenDespachada { get; internal set; }


        public ConfirmarOrdenDeEntregaModel()
        {
            var ordenesAdespachar = AlmacenOrdenesDePreparacion.OrdenDePreparacion;


            if (ordenesAdespachar != null)
            {
                var ordenesPreparadas = ordenesAdespachar.FindAll(p => p.EstadoOrden == Entidades.EstadoPreparacion.Preparada);

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

            var ordenesAEntregar = AlmacenOrdenesDePreparacion.OrdenDePreparacion;

            if (ordenesAEntregar != null)
            {
                var ordenesDespachadas = ordenesAEntregar.FindAll(p => p.EstadoOrden == Entidades.EstadoPreparacion.Despachada);

                OrdenesDeEntregaAEntregar = ordenesDespachadas.Select(ordenDEnt =>
                new OrdenDePreparacionDespachada
                {
                    NumeroDeOrden = ordenDEnt.NumeroDeOrden,
                    CodigoCliente = ordenDEnt.CodigoCliente,
                    Fecha = ordenDEnt.Fecha,
                    CodigoTransportista = ordenDEnt.CodigoTransportista,
                    Prioridad = ordenDEnt.Prioridad,
                    EstadoOrden = ordenDEnt.EstadoOrden,

                }).ToList();
            }
        }

    }
}
