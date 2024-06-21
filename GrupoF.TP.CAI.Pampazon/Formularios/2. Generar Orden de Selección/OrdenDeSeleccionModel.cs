using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.Prioridades;

namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    public class OrdenDeSeleccionModel
    {
        public string Cliente { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public string Transportista { get; set; }

        public string NumeroOrden { get; set; }

        public string Prioridad { get; set; }

        public List<OrdenDePreparacionPendiente> OrdenesConfirmadas { get; set; } = new List<OrdenDePreparacionPendiente>();
        public List<OrdenDePreparacionPendiente> OrdenDePreparacionPendientes { get; set; } = new List<OrdenDePreparacionPendiente>();
        public List<OrdenDePreparacionPendiente> OrdenDePreparacionSeleccionadas { get; set; } = new List<OrdenDePreparacionPendiente>();

        public OrdenDeSeleccionModel()
        {
            var ordenesDeSeleccion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts;

            if (ordenesDeSeleccion != null)
            {
                OrdenDePreparacionPendientes = ordenesDeSeleccion.Select(ordenesEnt =>
                    new OrdenDePreparacionPendiente
                    {
                        NumeroDeOrden = ordenesEnt.NumeroDeOrden,
                        Fecha = ordenesEnt.Fecha,
                        CodigoCliente = ordenesEnt.CodigoCliente,
                        CodigoTransportista = ordenesEnt.CodigoTransportista,
                        Prioridad = ordenesEnt.Prioridad,
                        EstadoOrden = ordenesEnt.EstadoOrden,
                    }).ToList();
            }
            else
            {
                MessageBox.Show("Debe ingresar una orden de preparacion");
            }
        }


        internal List<OrdenDePreparacionPendiente> FiltrarOrdenes()
        {
            var OrdenesFiltradas = OrdenDePreparacionPendientes
                .Where(p =>
                    (FechaDesde == DateTime.MinValue || p.Fecha >= FechaDesde) &&
                    (FechaHasta == DateTime.MinValue || p.Fecha <= FechaHasta) &&
                    (string.IsNullOrEmpty(Cliente) || p.CodigoCliente.Contains(Cliente, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(Transportista) || p.CodigoTransportista.Contains(Transportista, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(NumeroOrden) || p.NumeroDeOrden.Contains(NumeroOrden, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(Prioridad) || Enum.TryParse<Prioridad>(Prioridad, true, out var prioridad) && p.Prioridad == prioridad))
                .ToList();

            if (!OrdenesFiltradas.Any())
            {
                MessageBox.Show("No existen órdenes con las características indicadas.");
                return null;
            }

            return OrdenesFiltradas;
        }

        internal string ValidarFiltro()
        {
            /*
            
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

            */
            return null;
        }

        internal string ValidarOrden(OrdenDePreparacionPendiente ordenSeleccionada)
        {   // Arreglar esto para cuando se null
            if (ordenSeleccionada.EstadoOrden == Estados.Estado.Seleccion)
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

        private void RevertirEstadoOrden(OrdenDePreparacionPendiente ordenSeleccionada)
        {
            ordenSeleccionada.EstadoOrden = Estados.Estado.Pendiente;
            OrdenDePreparacionPendientes.Add(ordenSeleccionada);
            OrdenDePreparacionSeleccionadas.Remove(ordenSeleccionada);
        }

        internal void RegistrarOrden(List<OrdenDePreparacionPendiente> ordenesConfirmadas)
        {

            var ultimaOrden = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt
                .OrderByDescending(o => o.IdOrdenDeSeleccion)
                .FirstOrDefault();

            int ultimoId = 0;

            if (ultimaOrden != null && int.TryParse(ultimaOrden.IdOrdenDeSeleccion, out int id))
            {
                ultimoId = id;
            }


            ultimoId++;
            string nuevoIdOrdenDeSeleccion = ultimoId.ToString();



            var nuevaOrdenEnt = new OrdenDeSeleccionEnt
            {
                IdOrdenDeSeleccion = nuevoIdOrdenDeSeleccion,
                EstadoOrdenSeleccion = EstadoSeleccionEnum.EstadoSeleccion.Pendiente,
                SeleccionDetalle = new List<OrdenDeSeleccionDetalle>()
            };


            foreach (var orden in ordenesConfirmadas)
            {
                nuevaOrdenEnt.SeleccionDetalle.Add(new OrdenDeSeleccionDetalle
                {
                    NumeroDeOrden = orden.NumeroDeOrden
                });
                OrdenDePreparacionPendientes.Remove(orden);
                OrdenDePreparacionSeleccionadas.Add(orden);
            }

            AlmacenOrdenDeSeleccion.AgregarOrden(nuevaOrdenEnt);
            AlmacenOrdenesDePreparacion.ModificarEstadoEnOrdenes(nuevaOrdenEnt.SeleccionDetalle);

            ordenesConfirmadas.Clear();
        }

    }

}














