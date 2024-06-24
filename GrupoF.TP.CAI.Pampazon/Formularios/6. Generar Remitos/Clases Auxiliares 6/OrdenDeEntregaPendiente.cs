using GrupoF.TP.CAI.Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos.Clases_Auxiliares_6
{
    public class OrdenDeEntregaPendiente
    {
        public string IdOrdenDeEntrega { get; set; }

        public DateTime Fecha { get; set; }

        public string CodigoCliente { get; set; }

        public string CodigoTransportista { get; set; }

        public EstadoEntrega EstadoOrdenEntrega { get; set; }

        public List<string> EntregaDetalle { get; set; }
    }
}
