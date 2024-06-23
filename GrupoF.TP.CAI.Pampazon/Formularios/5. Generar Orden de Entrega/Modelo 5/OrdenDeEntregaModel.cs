using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoF.TP.CAI.Pampazon.Entidades.Prioridades;

namespace GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega
{
    public class OrdenDeEntregaModel
    {

        public string Cliente { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public string Transportista { get; set; }

        public string NumeroOrden { get; set; }

        public string Prioridad { get; set; }

        public List<OrdenDePreparacionSeleccionada> OrdenesSeleccionadas { get; set; } = new();

        public List<OrdenDePreparacionSeleccionada> OrdenesPreparadas { get; set; } = new();


        public OrdenDeEntregaModel()
        {
            var ordenes = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts.FindAll(o => o.EstadoOrden == Estados.Estado.Seleccionada);

            if (OrdenesSeleccionadas != null)
            {
                OrdenesSeleccionadas = ordenes.Select(ordenEnt => new OrdenDePreparacionSeleccionada
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

        internal List<OrdenDePreparacionSeleccionada> FiltrarOrdenes()
        {
            var OrdenesFiltradas = OrdenesSeleccionadas
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

        internal string ValidarOrden(OrdenDePreparacionSeleccionada ordenSeleccionada)
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

        private void RevertirEstadoOrden(OrdenDePreparacionSeleccionada ordenSeleccionada)
        {
            ordenSeleccionada.EstadoOrden = Estados.Estado.Seleccionada;
            OrdenesSeleccionadas.Add(ordenSeleccionada);
            OrdenesPreparadas.Remove(ordenSeleccionada);
        }

        internal void RegistrarOrden(List<OrdenDePreparacionSeleccionada> ordenesPreparadas)
        {
            var nuevaOrdenDeEntregaEnt = new OrdenDeEntregaEnt
            {
                Fecha = DateTime.Now,
                EstadoOrdenEntrega = EstadoEntregaEnum.EstadoEntrega.Pendiente,
                
                EntregaDetalle = new List<OrdenDeEntregaDetalle>()

            };

            foreach (var ordenPreparada in ordenesPreparadas)
            {
                var orden = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts.FirstOrDefault(o => o.NumeroDeOrden == ordenPreparada.NumeroDeOrden);
                if (orden != null)
                {
                    orden.EstadoOrden = Estados.Estado.Preparada;
                   
                    nuevaOrdenDeEntregaEnt.CodigoCliente =ordenPreparada.CodigoCliente;
                    nuevaOrdenDeEntregaEnt.CodigoTransportista = ordenPreparada.CodigoTransportista;
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
