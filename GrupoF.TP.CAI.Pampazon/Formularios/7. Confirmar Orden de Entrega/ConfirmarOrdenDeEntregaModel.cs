using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega
{
    public class ConfirmarOrdenDeEntregaModel
    {
         public List<OrdenDePreparacion> OrdenesDeEntregaAConfirmar { get; set; }
        public OrdenDePreparacion OrdenADespachada { get; internal set; }
    }
}
