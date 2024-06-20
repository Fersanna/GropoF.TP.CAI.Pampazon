using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.EstadoEntregaEnum;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    internal class OrdenDeEntregaEnt
    {
        public string IdOrdenDeEntrega {get; set;}

        public DateTime Fecha {get; set;}
  
        public EstadoEntrega EstadoEntrega{get; set; }

        public List<OrdenDeEntregaDetalle> EntregaDetalle {get; set;}

    }
}
