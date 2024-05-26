using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public class GenerarRemitosModel
    {   
        public OrdenDePreparacion OrdenSeleccionada {get; set;}
        public List<OrdenDePreparacion> OrdenesDeEntrega { get; set; } = new List<OrdenDePreparacion> {

            new OrdenDePreparacion {
                NumeroDeOrden = "P-000001",
                CodigoCliente = "Moron Construcciones",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 1",
                EstadoOrden = "Confirmada",
                ProductosOrden= new List <Productos>  {
                new Productos
                {
                    IdProducto = "A1",
                    Descripcion = "Producto 1",
                    Posicion = "X-Y-Z",
                    Cantidad = 5
                },
                 new Productos
                {
                    IdProducto = "A2",
                    Descripcion = "Producto 2",
                    Posicion = "X-Y-Z",
                    Cantidad = 18
                }
            }
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000002",
                CodigoCliente = "Fortin SRL",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 2",
                EstadoOrden = "Confirmada"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000003",
                CodigoCliente = "Valentin Gomez S.A",
                Fecha = new DateTime(2024, 5, 14),
                CodigoTransportista = "Transportista 3",
                EstadoOrden = "Confirmada"
            },

            };
    }
}
