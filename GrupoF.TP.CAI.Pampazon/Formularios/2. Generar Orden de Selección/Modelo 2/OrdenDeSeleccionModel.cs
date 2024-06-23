using GrupoF.TP.CAI.Pampazon.Almacenes;
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
                    (string.IsNullOrEmpty(Cliente) || p.CodigoCliente.Equals(Cliente, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(Transportista) || p.CodigoTransportista.Equals(Transportista, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(NumeroOrden) || p.NumeroDeOrden.Equals(NumeroOrden, StringComparison.OrdinalIgnoreCase)) &&
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
            // Validar Prioridad
            if (!string.IsNullOrEmpty(Prioridad) && !Prioridad.Equals("1", StringComparison.OrdinalIgnoreCase) &&
                !Prioridad.Equals("2", StringComparison.OrdinalIgnoreCase) &&
                !Prioridad.Equals("3", StringComparison.OrdinalIgnoreCase))
            {
                return "Ingrese un valor válido para la Prioridad (1, 2 o 3).";
            }

            // Validar Rango de fecha
            if (FechaDesde > FechaHasta)
            {
                return "La fecha Desde no puede ser mayor que la fecha Hasta.";
            }

            // Validar Número de Orden numérico
            if (!string.IsNullOrEmpty(NumeroOrden) && !int.TryParse(NumeroOrden, out _))
            {
                return "El número de orden debe ser un valor numérico.";
            }

            return null;
        }

        internal string ValidarOrden(OrdenDePreparacionPendiente ordenSeleccionada)
        {   // Arreglar esto para cuando se null
            if (ordenSeleccionada.EstadoOrden == Estados.Estado.Seleccion)
            {
                RevertirEstadoOrden(ordenSeleccionada);
                return "Orden revertida a pendiente.";

                /*
                DialogResult result = MessageBox.Show("Esta orden ya fue seleccionada. ¿Desea quitarla de la selección?", "Confirmación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    
                }
                */
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














