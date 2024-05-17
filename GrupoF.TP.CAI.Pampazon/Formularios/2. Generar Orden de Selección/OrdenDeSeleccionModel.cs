using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    internal class OrdenDeSeleccionModel
    {
        public List<OrdenDePreparacion> OrdenDePreparacion { get; set; } = new List<OrdenDePreparacion>
        {
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000001",
                CodigoCliente = "001",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 1",
                EstadoOrden = "Pendiente"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000002",
                CodigoCliente = "002",
                Fecha = new DateTime(2024, 5, 13),
                CodigoTransportista = "Transportista 2",
                EstadoOrden = "Pendiente"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000003",
                CodigoCliente = "003",
                Fecha = new DateTime(2024, 5, 14),
                CodigoTransportista = "Transportista 3",
                EstadoOrden = "Pendiente"
            },
            new OrdenDePreparacion
            {
                NumeroDeOrden = "P-000004",
                CodigoCliente = "002",
                Fecha = new DateTime(2024, 5, 15),
                CodigoTransportista = "Transportista 4",
                EstadoOrden = "Pendiente"
            }
        };


    }


}













