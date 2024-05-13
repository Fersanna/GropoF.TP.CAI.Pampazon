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
        public List<OrdenDeSeleccion> OrdenesPendientesDeValidar { get; set; }
        public Clientes ClienteSeleccionado { get; set; }
        public OrdenDeSeleccion ClienteOrden { get; set; }
        public List<Clientes> Clientes { get; set; } = new List<Clientes>


        {
        new Clientes
        {
            CodigoCliente = "001",
            RazonSocial = "Cliente 1",
            Cuit = "20-12345678-9",
            Domicilio = "Dirección 1",
            Productos = new List<Productos>
            {
                new Productos
                {
                    IdProducto = "AA1",
                    Descripcion = "Descripción del Producto 1",
                    Posicion = "Almacén 3",
                    Cantidad = 15
                },
                 new Productos
                {
                    IdProducto = "AA2",
                    Descripcion = "Descripción del Producto 1",
                    Posicion = "Almacén 2",
                    Cantidad = 18
                }
            }
        },  // Añade una coma aquí para separar los elementos de la lista

        new Clientes
        {
            CodigoCliente = "002",
            RazonSocial = "Cliente 2",
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
        },  // Nuevamente, asegúrate de poner la coma para separar los clientes

        new Clientes
        {
            CodigoCliente = "003",
            RazonSocial = "Cliente 3",
            Cuit = "20-19283746-9",
            Domicilio = "Dirección 3"
            // Parece que el Cliente 3 no tiene productos definidos
        }
        };

        internal string ValidarCantidadProductos()
        {
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
                else if (productoOrden.Cantidad > productoCliente.Cantidad)
                {
                    return $"La cantidad pedida para el producto {productoOrden.IdProducto} excede la cantidad disponible. Disponible: {productoCliente.Cantidad}, Pedida: {productoOrden.Cantidad}.";
                }
            }

            return null;
        }
    }
}



