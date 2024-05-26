using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación.Clases_Auxiliares
{
    public class Remito
    {
        public int NumeroRemito {get; set;}
        public DateTime FechaRemito {get; set;}

        public Clientes Cliente {get; set;}

        public List<Productos> Productos {get; set;}
    }
}
