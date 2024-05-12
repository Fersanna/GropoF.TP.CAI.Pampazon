using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Clases_Auxiliares
{
    public class OrdenDeSeleccion
    {
        private static int contadorOrdenes = 0;
        public string NumeroDeOrden {get; set; }

        public DateTime Fecha {get; set; }

        public string CodigoCliente {get; set; }    
        public string CodigoTransportista {get; set;}
        public string EstadoOrden{get; set; }

        public List<Productos> ProductosOrden {get; set; }


        public OrdenDeSeleccion()
        {
            ProductosOrden = new List<Productos>();

            NumeroDeOrden = contadorOrdenes.ToString();
            contadorOrdenes++;
        }


    }
}
