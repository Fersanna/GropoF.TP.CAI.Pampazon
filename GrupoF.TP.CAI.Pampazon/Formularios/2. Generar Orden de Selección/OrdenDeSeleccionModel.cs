using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    public class OrdenDeSeleccionModel
    {
        public string Cliente { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public string Transportista {get; set; }

        public string NumeroOrden { get; set; }

        public List<OrdenDePreparacion> OrdenesConfirmadas { get; set; }
        public List<OrdenDePreparacion> OrdenDePreparacion { get; set; } = new List<OrdenDePreparacion>
        {
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000001",
                CodigoCliente = "Moron Construcciones",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 1",
                EstadoOrden = "Pendiente"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000002",
                CodigoCliente = "Fortin SRL",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 2",
                EstadoOrden = "Pendiente"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000003",
                CodigoCliente = "Valentin Gomez S.A",
                Fecha = new DateTime(2024, 5, 14),
                CodigoTransportista = "Transportista 3",
                EstadoOrden = "Pendiente"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000004",
                CodigoCliente = "Almada S.A",
                Fecha = new DateTime(2024, 5, 15),
                CodigoTransportista = "Transportista 4",
                EstadoOrden = "Pendiente"
            }
        };

        internal List<OrdenDePreparacion> FiltrarOrdenes()
        {
            var OrdenesFiltradas = OrdenDePreparacion
                .Where(p => p.Fecha >= FechaDesde && p.Fecha <= FechaHasta &&
                    (string.IsNullOrEmpty(Cliente) || p.CodigoCliente.Contains(Cliente, StringComparison.OrdinalIgnoreCase) || p.CodigoTransportista.Contains(Transportista, StringComparison.OrdinalIgnoreCase) || p.NumeroDeOrden.Contains(NumeroOrden, StringComparison.OrdinalIgnoreCase)))
                 .ToList();
            if (!OrdenesFiltradas.Any())
            {
                MessageBox.Show("No existen Ordenes con esas carcartesticas para el rango de fecha indicado");
                return null;
            }


            return OrdenesFiltradas;
        }

        internal string ValidarFiltro()
        {
            if (string.IsNullOrWhiteSpace(Cliente))
            {
                return "El nombre del cliente no puede estar vacío.";
            }
            if (Cliente.Length > 30)
            {
                return "El nombre del cliente no puede tener más de 30 caracteres.";
            }
            

            if (string.IsNullOrWhiteSpace(Transportista))
            {
                return "El nombre del Transportista no puede estar vacío.";
            }

              if (string.IsNullOrWhiteSpace(NumeroOrden))
            {
                return "El numero de orden no puede estar vacío.";
            }

            return null;
        }

        internal string ValidarOrden(OrdenDePreparacion ordenSeleccionada)
        {   // Arreglar esto para cuando se null
            if (ordenSeleccionada.EstadoOrden == "Seleccionada")
            {
                DialogResult result = MessageBox.Show("Esta orden ya fue seleccionada. ¿Desea quitarla de la selección?", "Confirmación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    RevertirEstadoOrden(ordenSeleccionada);
                    return "Orden revertida a pendiente.";
                }
            }


            return null;

        }

        private void RevertirEstadoOrden(OrdenDePreparacion ordenSeleccionada)
        {
            ordenSeleccionada.EstadoOrden = "Pendiente";
        }
    }


}













