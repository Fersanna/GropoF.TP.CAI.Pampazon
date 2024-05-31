using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Modulos
{
    public static class ModuloClientes
    {
       public static ClienteEnt ObtenerClientePorCuit(string cuit)
        {
            
            return AlmacenClientes.Clientes.FirstOrDefault(cliente => cliente.Cuit == cuit);
        }
    }
}
