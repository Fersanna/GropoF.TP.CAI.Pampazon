using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.Estados;
using static GrupoF.TP.CAI.Pampazon.Entidades.Prioridades;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class OrdenDePreparacionEnt
    {
        public string NumeroDeOrden { get; set; } =string.Empty;
        public DateTime Fecha { get; set; }

        public string CodigoCliente { get; set; }

        public string CodigoTransportista { get; set; }

        public Prioridad Prioridad { get; set; }

        public Estado EstadoOrden { get; set; }

        public List<OrdenDePreparacionDetalle> Detalle { get; set; }

        public OrdenDePreparacionEnt()
        {
            NumeroDeOrden = "0"; 
            Fecha = DateTime.Now; 
            CodigoCliente = string.Empty;
            CodigoTransportista = string.Empty;
            Detalle = new List<OrdenDePreparacionDetalle>();
        }

    }
}
