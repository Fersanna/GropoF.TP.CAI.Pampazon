using GrupoF.TP.CAI.Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.EstadoSeleccionEnum;

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares
{
    public class OrdenDeSeleccionPendiente
    {
        public string IdOrdenDeSeleccion { get; set; }
        public EstadoSeleccion EstadoOrdenSeleccion { get; set; }
    }
}

