using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Modelos
{
    public  class BuscarClienteModel
    {
        public Clientes ClienteSeleccionado { get; set; }
        public List<Clientes> Clientes { get; set; } = new List<Clientes>
               {
        new Clientes { CodigoCliente = "001",
                       RazonSocial = "Cliente 1",
                       Cuit = "20-12345678-9",
                       Domicilio = "Dirección 1",
                       Productos = new List<Productos> ()
                       {
                           new Productos
                           {
                            IdProducto = "AA1",
                            Descripcion = "Descripción del Producto 1",
                            Posicion = "Almacén 3",
                            Cantidad = 15
                           }

                       }

                      },


        new Clientes { CodigoCliente = "002",
                       RazonSocial = "Cliente 2",
                       Cuit = "20-87654321-9",
                       Domicilio = "Dirección 2" },

        new Clientes { CodigoCliente = "003",
                       RazonSocial = "Cliente 3",
                       Cuit = "20-19283746-9",
                       Domicilio = "Dirección 3" }
    };

    }
}
