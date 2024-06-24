using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Confirmar_Orden_de_Seleccion.Modelo_3;

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición;

public class ConfirmarOrdenDeSeleccionModel
{
    private readonly Dictionary<string, CantidadASeleccionar> cantidadesPorProductoPosicion = new();

    public List<OrdenDeSeleccionPendiente> OrdenesSeleccionPendientes { get; set; } = new List<OrdenDeSeleccionPendiente>();

    public OrdenDeSeleccionPendiente OrdenDeSeleccionElegida { get; internal set; }

    public ConfirmarOrdenDeSeleccionModel()
    {
        CargarOrdenesSeleccion();
    }


    public List<CantidadASeleccionar> CantidadesAcumuladas()
    {
        var ordenSeleccion = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt.Where(o => o.IdOrdenDeSeleccion == OrdenDeSeleccionElegida.IdOrdenDeSeleccion).Single();
        foreach (var detalleOrdenSeleccion in ordenSeleccion.SeleccionDetalle)
        {
            var ordenPreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacion.First(o => o.NumeroDeOrden == detalleOrdenSeleccion.NumeroDeOrden);

            foreach (var ordenPreparacionDetalle in ordenPreparacion.Detalle)
            {
                var cantidadASeleccionar = ordenPreparacionDetalle.Cantidad;

                foreach (var productoPosicionStock in AlmacenProductos.Productos.Where(p => p.IdProducto == ordenPreparacionDetalle.IdProducto && p.Stock > 0))
                {
                    var cantidadASacarDeLaPosicion = Math.Min(productoPosicionStock.Stock, cantidadASeleccionar);

                    if (cantidadesPorProductoPosicion.TryGetValue(productoPosicionStock.IdProducto, out var posicion))
                    {
                        posicion.Cantidad += cantidadASacarDeLaPosicion;
                    }
                    else
                    {
                        cantidadesPorProductoPosicion.Add(productoPosicionStock.IdProducto, new()
                        {
                            idproducto = productoPosicionStock.IdProducto,
                            DescripcionProducto = productoPosicionStock.Descripcion,
                            CodigoCliente = ordenPreparacion.CodigoCliente,
                            Posicion = productoPosicionStock.Posicion,
                            Cantidad = cantidadASacarDeLaPosicion
                        });
                    }

                    cantidadASeleccionar -= cantidadASacarDeLaPosicion;
                    if (cantidadASeleccionar == 0)
                    {
                        break;
                    }
                }
            }
        }

        return cantidadesPorProductoPosicion.Values.ToList();
    }


    internal void Confirmar()
    {
        AlmacenOrdenDeSeleccion.CambiarEstadoOrdenSeleccion(OrdenDeSeleccionElegida.IdOrdenDeSeleccion, EstadoSeleccion.Cumplida);


        AlmacenProductos.DarDeBajaStock(cantidadesPorProductoPosicion.Select(d => (d.Value.idproducto, d.Value.Posicion, d.Value.Cantidad)).ToList());
        CargarOrdenesSeleccion();
    }

    private void CargarOrdenesSeleccion()
    {
        OrdenesSeleccionPendientes = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt
                                .Where(o => o.EstadoOrdenSeleccion == EstadoSeleccion.Pendiente)
                                .Select(ordenEnt => new OrdenDeSeleccionPendiente
                                {
                                    IdOrdenDeSeleccion = ordenEnt.IdOrdenDeSeleccion,
                                    EstadoOrdenSeleccion = ordenEnt.EstadoOrdenSeleccion,
                                    SeleccionDetalle = ordenEnt.SeleccionDetalle.Select(d => d.NumeroDeOrden).ToList()
                                })
                                .ToList();

    }

}



