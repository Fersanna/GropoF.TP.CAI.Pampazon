using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
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

        public string Transportista { get; set; }

        public string NumeroOrden { get; set; }

        public List<OrdenDeSeleccion> OrdenesConfirmadas { get; set; }
        public List<OrdenDeSeleccion> OrdenDePreparacion { get; set; }

        public OrdenDeSeleccionModel()
        {

            var ordenesDeSeleccion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts;

            if (ordenesDeSeleccion != null)
            {
                OrdenDePreparacion = ordenesDeSeleccion.Select(ordenesEnt =>
                 new OrdenDeSeleccion
                 {
                     NumeroDeOrden = ordenesEnt.NumeroDeOrden,
                     Fecha = ordenesEnt.Fecha,
                     CodigoCliente = ordenesEnt.CodigoCliente,
                     CodigoTransportista = ordenesEnt.CodigoTransportista,
                     EstadoOrden = ordenesEnt.EstadoOrden,

                 }).ToList();
            }
            else
                MessageBox.Show("Debe ingresar una orden de preparacion");



        }


        internal List<OrdenDeSeleccion> FiltrarOrdenes()
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

        internal string ValidarOrden(OrdenDeSeleccion ordenSeleccionada)
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

        private void RevertirEstadoOrden(OrdenDeSeleccion ordenSeleccionada)
        {
            ordenSeleccionada.EstadoOrden = Estados.Estado.Pendiente;
        }

        internal void RegistrarOrden(List<OrdenDeSeleccion> ordenesConfirmadas)
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
                Estado = Estados.Estado.Seleccionada,
                SeleccionDetalle = new List<OrdenDeSeleccionDetalle>()
            };

            
            foreach (var orden in ordenesConfirmadas)
            {
                nuevaOrdenEnt.SeleccionDetalle.Add(new OrdenDeSeleccionDetalle
                {
                    NumeroDeOrden = orden.NumeroDeOrden
                });
            }

          
            AlmacenOrdenDeSeleccion.AgregarOrden(nuevaOrdenEnt);
            AlmacenOrdenesDePreparacion.ModificarEstadoEnOrdenes(nuevaOrdenEnt.SeleccionDetalle);
        }

    }

}














