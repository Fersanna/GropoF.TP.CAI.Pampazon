using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class EstadoSeleccionEnum
    {
        public enum EstadoSeleccion
        {
            [Description("Pendiente")]
            Pendiente,
            [Description("Cumplida")]
            Cumplida
        }
    }
}
