using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    internal class ConfirmarOrdenSeleccionadaFormModel
    {
         public List<OrdenDeSeleccion> OrdenEnSeleccion { get; set; } = new List<OrdenDeSeleccion>
        {
            new OrdenDeSeleccion
            {
                NumeroDeOrden = "P-000001",
                CodigoCliente = "Moron Construcciones",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 1",
                EstadoOrden = "En selección"
            },
            new OrdenDeSeleccion
            {
                NumeroDeOrden = "P-000002",
                CodigoCliente = "Fortin SRL",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 2",
                EstadoOrden = "En selección"
            },
            new OrdenDeSeleccion
            {
                NumeroDeOrden = "P-000003",
                CodigoCliente = "Valentin Gomez S.A",
                Fecha = new DateTime(2024, 5, 14),
                CodigoTransportista = "Transportista 3",
                EstadoOrden = "En selección"
            },
            new OrdenDeSeleccion
            {
                NumeroDeOrden = "P-000004",
                CodigoCliente = "Almada S.A",
                Fecha = new DateTime(2024, 5, 15),
                CodigoTransportista = "Transportista 4",
                EstadoOrden = "En selección"
            }
        };
        //Seguir x aca
        public  ConfirmarOrdenSeleccionadaFormModel()
        {
            var ordenesAconfirmar = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt;
           
            if (ordenesAconfirmar != null)
            {
                OrdenEnSeleccion = ordenesAconfirmar.Select(ordenEnt =>
                new OrdenDeSeleccion
                {
                    NumeroDeOrden = ordenEnt.IdOrdenDeSeleccion
                }).ToList();
            }
        }

        internal void CambiarEstadoEnOrden(OrdenDeSeleccion orden)
        {
           if (orden.EstadoOrden != "En selección")
            {
                MessageBox.Show("Esta Orden ya ha sido seleccionada");
            }
           else
            {
                orden.EstadoOrden = "Seleccionada";
                return;
            }

        }
    }
}
