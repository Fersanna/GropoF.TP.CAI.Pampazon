using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    internal class OrdenDeEntregaEnt
    {
        public string IdOrdenDeEntrega {get; set;}

        public DateTime Fecha {get; set;}
        public string CodigoCliente {get; set;}

        public string CodigoTransportista {get;set;}

        public EstadoEntregaEnum EstadoEntrega{get; set; }

        public List<OrdenDeEntregaDetalle> EntregaDetalle {get; set;}

    }
}
