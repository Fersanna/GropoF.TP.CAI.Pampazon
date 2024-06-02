using GrupoF.TP.CAI.Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Clases_Auxiliares
{
    public  class Clientes
    {
        public string CodigoCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public List<Productos> Productos { get; set; }

        public Clientes()
        {
            Productos= new List<Productos>();

        }

         public Clientes(ClienteEnt clienteEnt)
        {
            CodigoCliente = clienteEnt.CodigoCliente;
            RazonSocial = clienteEnt.RazonSocial;
            Cuit = clienteEnt.Cuit;
            Domicilio = clienteEnt.Domicilio;
           
        }
    }
}
