using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
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

        public string CodigoCliente {get; set;}
        public List <Productos> DetalleProductos {get; set;}

    }
}
