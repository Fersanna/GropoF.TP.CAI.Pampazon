using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos.Clases_Auxiliares_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public class GenerarRemitosModel
    {
        public OrdenDeEntregaPendiente OrdenSeleccionada { get; set; }
        public List<OrdenDeEntregaPendiente> OrdenesDeEntrega { get; set; }

        public GenerarRemitosModel()
        {
            OrdenesDeEntrega = AlmacenOrdenDeEntrega.OrdenDeEntregaEnts.Select(ordenEnt => new OrdenDeEntregaPendiente
            {
                IdOrdenDeEntrega = ordenEnt.IdOrdenDeEntrega,
                Fecha = ordenEnt.Fecha,
               // EstadoOrden = ordenEnt.EstadoEntrega,
               //Hay que hacer una nueva clase auxiliar 
            }
              ).ToList();
        }
    }
}
