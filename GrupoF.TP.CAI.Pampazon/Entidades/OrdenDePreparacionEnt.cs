using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class OrdenDePreparacionEnt
    {
        public string NumeroDeOrden { get; set; } 
        public DateTime Fecha { get; set; }

        public string CodigoCliente { get; set; }

        public string CodigoTransportista { get; set; }

        public Prioridad Prioridad { get; set; }

        public EstadoPreparacion EstadoOrden { get; set; }

        public List<OrdenDePreparacionDetalle> Detalle { get; set; }

        public OrdenDePreparacionEnt()
        {
          
        }

    }
}
