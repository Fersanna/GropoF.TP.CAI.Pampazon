using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega
{
    public class OrdenDeEntregaModel
    {

        public string Cliente { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public string Transportista { get; set; }

        public string NumeroOrden { get; set; }

        public List<OrdenDePreparacion> OrdenesSeleccionadas { get; set; } = new();

        public List<OrdenDePreparacion> OrdenesPreparadas { get; set; } = new();


        public OrdenDeEntregaModel()
        {
            var ordenes = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts.FindAll(o => o.EstadoOrden == Estados.Estado.Seleccionada);

            if (OrdenesSeleccionadas != null)
            {
                OrdenesSeleccionadas = ordenes.Select(ordenEnt => new OrdenDePreparacion
                {
                    NumeroDeOrden = ordenEnt.NumeroDeOrden,
                    Fecha = ordenEnt.Fecha,
                    CodigoCliente = ordenEnt.CodigoCliente,
                    CodigoTransportista = ordenEnt.CodigoTransportista,
                    Prioridad = ordenEnt.Prioridad,
                    EstadoOrden = ordenEnt.EstadoOrden
                }).ToList();
            }
            else
            {
                MessageBox.Show("Debe ingresar una orden de preparacion");
            }
        }

        internal List<OrdenDePreparacion> FiltrarOrdenes()
        {
            var OrdenesFiltradas = OrdenesSeleccionadas.Where
                   (p => p.Fecha >= FechaDesde && p.Fecha <= FechaHasta &&
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
            if (ordenSeleccionada.EstadoOrden == Estados.Estado.Preparada)
            {
                DialogResult result = MessageBox.Show("Esta orden ya fue seleccionada. ¿Desea quitarla de la selección?", "Confirmación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    RevertirEstadoOrden(ordenSeleccionada);
                    return "Orden revertida a Seleccionada.";
                }
            }


            return null;

        }

        private void RevertirEstadoOrden(OrdenDePreparacion ordenSeleccionada)
        {
            ordenSeleccionada.EstadoOrden = Estados.Estado.Seleccionada;
            OrdenesSeleccionadas.Add(ordenSeleccionada);
            OrdenesPreparadas.Remove(ordenSeleccionada);
        }

        internal void RegistrarOrden(List<OrdenDePreparacion> ordenesPreparadas)
        {
            var nuevaOrdenDeEntregaEnt = new OrdenDeEntregaEnt
            {
                Fecha = DateTime.Now,
                EstadoEntrega = EstadoEntregaEnum.EstadoEntrega.Generada,
                EntregaDetalle = new List<OrdenDeEntregaDetalle>()

            };

            foreach (var ordenPreparada in ordenesPreparadas)
            {
                var orden = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts.FirstOrDefault(o => o.NumeroDeOrden == ordenPreparada.NumeroDeOrden);
                if (orden != null)
                {
                    orden.EstadoOrden = Estados.Estado.Preparada;
                    nuevaOrdenDeEntregaEnt.EntregaDetalle.Add(new OrdenDeEntregaDetalle
                    {
                        NumeroDeOrden = orden.NumeroDeOrden
                    });
                }

            }

            AlmacenOrdenDeEntrega.AgregarOrdenDeEntrega(nuevaOrdenDeEntregaEnt);
            AlmacenOrdenesDePreparacion.Grabar();
           
        }
    }


};
