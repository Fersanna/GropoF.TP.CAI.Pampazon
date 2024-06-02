using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
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
       
        //seguir por aca (Ensamblar ClientesEnt con Clientes y luego insertar codigo ObtenerListaClientes en el loal)
        public static List<Clientes> ObtenerListaClientes()
        {
             return AlmacenClientes.Clientes.Select(clienteEnt => new Clientes(clienteEnt)).ToList();
        }
    }
}
