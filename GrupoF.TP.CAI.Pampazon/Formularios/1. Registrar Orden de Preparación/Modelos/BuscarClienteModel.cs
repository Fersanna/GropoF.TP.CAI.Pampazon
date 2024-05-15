using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Modelos
{
    public class BuscarClienteModel
    {
        public Clientes ClienteSeleccionado { get; set; }
        public OrdenDeSeleccion ClienteOrden { get; set; }
        public string Cuit { get; set; }
        public List<Clientes> Clientes { get; set; } = new List<Clientes>


        {
        new Clientes
        {
            CodigoCliente = "001",
            RazonSocial = "Industrias Miranda",
            Cuit = "20-12345678-9",
            Domicilio = "Dirección 1",
            Productos = new List<Productos>
            {
                new Productos
                {
                    IdProducto = "A1",
                    Descripcion = "Producto 1",
                    Posicion = "X-Y-Z",
                    Cantidad = 5
                },
                 new Productos
                {
                    IdProducto = "AA2",
                    Descripcion = "Descripción del Producto 1",
                    Posicion = "Almacén 2",
                    Cantidad = 18
                }
            }
        },

        new Clientes
        {
            CodigoCliente = "002",
            RazonSocial = "Editorial Ramírez",
            Cuit = "20-87654321-9",
            Domicilio = "Dirección 2",
            Productos = new List<Productos>
            {
                new Productos
                {
                    IdProducto = "AA2",
                    Descripcion = "Descripción del Producto 1",
                    Posicion = "Almacén 2",
                    Cantidad = 18
                }
            }
        },

        new Clientes
        {
            CodigoCliente = "003",
            RazonSocial = "Constructora López",
            Cuit = "20-19283746-9",
            Domicilio = "Dirección 3"

        }
        };

        internal string QuitarProductoDelaOrden(Productos producto)
        {
            if (producto != null)
            {
                // Busca el producto en la lista de productos de la orden y lo elimina
                var productoEncontrado = ClienteOrden.ProductosOrden.FirstOrDefault(p => p.IdProducto == producto.IdProducto);
                if (productoEncontrado != null)
                {
                    ClienteOrden.ProductosOrden.Remove(productoEncontrado);
                    return null; // No hay error
                }
                else
                {
                    return "El producto seleccionado no se encontró en la orden.";
                }
            }
            else
            {
                return "El producto seleccionado es nulo.";
            }
        }

        internal string ValidarCantidadProductos()
        {
            if (ClienteOrden == null || ClienteOrden.ProductosOrden == null || !ClienteOrden.ProductosOrden.Any())
            {
                return "Debe agregar al menos un producto para generar la orden.";
            }



            var clienteEncontrado = Clientes.FirstOrDefault(c => c.CodigoCliente == ClienteOrden.CodigoCliente);

            if (clienteEncontrado == null)
            {
                return "El cliente no se ha encontrado";
            }

            foreach (var productoOrden in ClienteOrden.ProductosOrden)
            {
                var productoCliente = clienteEncontrado.Productos?.FirstOrDefault(p => p.IdProducto == productoOrden.IdProducto);
                if (productoCliente == null)
                {
                    return $"Producto con ID {productoOrden.IdProducto} no encontrado en la lista del cliente.";
                }
                if (productoOrden.Cantidad > productoCliente.Cantidad)
                {
                    return $"La cantidad pedida para el producto {productoOrden.IdProducto} excede la cantidad disponible. Disponible: {productoCliente.Cantidad}, Pedida: {productoOrden.Cantidad}.";
                }
                if (productoOrden.Cantidad <= 0)
                {
                    return $"La cantidad pedida para el producto {productoOrden.IdProducto} debe ser mayor que cero.";
                }
            }

            return null;
        }
    }
}



