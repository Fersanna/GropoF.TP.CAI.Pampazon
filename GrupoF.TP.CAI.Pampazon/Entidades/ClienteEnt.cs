using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class ClienteEnt
    {
        public string CodigoCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public List<string> IdProductos { get; set; }

        public ClienteEnt()
        {
            IdProductos = new List<string>();
        }
    }
}
