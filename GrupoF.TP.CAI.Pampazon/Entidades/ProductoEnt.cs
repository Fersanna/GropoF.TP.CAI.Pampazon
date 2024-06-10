using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class ProductoEnt
    {
        public string IdProducto { get; set; }
        public string Descripcion { get; set; }
        public List<ProductoPosicion> Posiciones { get; set;}
        public int Stock {get; set; }       
    }
}
