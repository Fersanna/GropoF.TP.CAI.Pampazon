using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.Estados;
using static GrupoF.TP.CAI.Pampazon.Entidades.EstadoSeleccionEnum;
using static GrupoF.TP.CAI.Pampazon.Entidades.Prioridades;

namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares
{
    public class OrdenDePreparacionPendiente
    {
       
        public string NumeroDeOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoTransportista { get; set; }
        public Estado EstadoOrden { get; set; }

        public Prioridad Prioridad { get; set; }


        public OrdenDePreparacionPendiente()
        {
            
        }
    }
}
