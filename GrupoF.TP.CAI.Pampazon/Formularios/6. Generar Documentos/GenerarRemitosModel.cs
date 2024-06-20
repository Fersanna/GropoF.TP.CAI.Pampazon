using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public class GenerarRemitosModel
    {
        public OrdenDePreparacion OrdenSeleccionada { get; set; }
        public List<OrdenDePreparacion> OrdenesDeEntrega { get; set; }

        public GenerarRemitosModel()
        {
            OrdenesDeEntrega = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts.Select(ordenEnt => new OrdenDePreparacion
            {
                NumeroDeOrden = ordenEnt.IdOrdenDeEntrega,
                Fecha = ordenEnt.Fecha,
               // EstadoOrden = ordenEnt.EstadoEntrega,
               //Hay que hacer una nueva clase auxiliar 
            }
              ).ToList();
        }
    }
}
