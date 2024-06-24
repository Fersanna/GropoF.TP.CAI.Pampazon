using GrupoF.TP.CAI.Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_Auxiliares_7
{
    public class OrdenDePreparacionDespachada
    {
        public string NumeroDeOrden { get; set; }
        public DateTime Fecha { get; set; }

        public string CodigoCliente { get; set; }
        public string CodigoTransportista { get; set; }
        public EstadoPreparacion EstadoOrden { get; set; }

        public Prioridad Prioridad { get; set; }
    }
}
