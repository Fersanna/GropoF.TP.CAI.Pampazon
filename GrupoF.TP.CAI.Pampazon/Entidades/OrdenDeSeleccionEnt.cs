using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.Estados;
using static GrupoF.TP.CAI.Pampazon.Entidades.EstadoSeleccionEnum;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class OrdenDeSeleccionEnt
    {
       
        public string IdOrdenDeSeleccion {get; set; }

        public EstadoSeleccion EstadoSeleccion {get; set; }

        public List<OrdenDeSeleccionDetalle> SeleccionDetalle {get; set;}
    }
}
