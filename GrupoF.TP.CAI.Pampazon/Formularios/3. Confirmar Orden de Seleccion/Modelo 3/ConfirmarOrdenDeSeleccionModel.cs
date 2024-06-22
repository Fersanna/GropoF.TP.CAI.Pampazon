using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    public class ConfirmarOrdenDeSeleccionModel
    {
        public List<OrdenDeSeleccionPendiente> OrdenesSeleccionPendientes { get; set; } = new List<OrdenDeSeleccionPendiente>();

        public OrdenDeSeleccionPendiente OrdenDeSeleccionElegida { get; internal set; }

        public ConfirmarOrdenDeSeleccionModel()
        {
            var ordenesDeSeleccion = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt;

            if (ordenesDeSeleccion != null)
            {
                OrdenesSeleccionPendientes = ordenesDeSeleccion
                                                .Select(ordenEnt => new OrdenDeSeleccionPendiente
                                                                      {
                                                                          IdOrdenDeSeleccion = ordenEnt.IdOrdenDeSeleccion,
                                                                          EstadoOrdenSeleccion = ordenEnt.EstadoOrdenSeleccion,
                                                                          SeleccionDetalle = ordenEnt.SeleccionDetalle.Select(d => d.NumeroDeOrden).ToList()
                                                                      })
                                                .ToList();
            }
            else
            {
                MessageBox.Show("Debe ingresar una orden de selección");
            }
        }

        internal string Confirmar()
        {
           /* //TODO: verificar que haya stock? 
            foreach (var detalle in OrdenDeSeleccionElegida.SeleccionDetalle)
            {
                var producto = AlmacenProductos.Productos.FirstOrDefault(p => p.IdProducto == detalle.NumeroDeOrden);

                if (producto == null || producto.Stock <= 0)
                {
                    return $"No hay suficiente stock para el producto {detalle.NumeroDeOrden}.";
                }
            }
            //TODO: bajar el stock
            foreach (var detalle in OrdenDeSeleccionElegida.SeleccionDetalle)
            {
                var producto = AlmacenProductos.Productos.FirstOrDefault(p => p.IdProducto == detalle.NumeroDeOrden);

                if (producto != null)
                {
                    producto.Stock -= 1;  // Asumimos que se descuenta una unidad por cada selección
                }
            }
            //TODO: Recargar la lista OrdenesSeleccionPendientes.
            AlmacenProductos.Grabar();*/



            OrdenDeSeleccionElegida = null;
            //si hay algun error string con mensaje para el usuario, si no devolver null
            return null;
        }
    }
}


