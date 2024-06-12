using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.Estados;

namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    public class OrdenDeSeleccion
    {
        public string NumeroDeOrden { get; set; }
        public DateTime Fecha { get; set; }
        
        public Estado Estado { get; set; }
        public List<string> OrdenesSeleccionadas{ get; set; }
    }
}
