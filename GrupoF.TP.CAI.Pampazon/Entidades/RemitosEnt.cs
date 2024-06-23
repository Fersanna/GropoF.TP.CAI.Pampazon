using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    internal class RemitosEnt
    {
        public int IdRemito {get; set;}
        public DateTime FechaRemito {get; set;}

        public string Detalle {get; set;}

        public int Cantidad {get; set;} 
    }
}
