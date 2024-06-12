using System;
using System.ComponentModel;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class Estados
    {
        public enum Estado
        {
            [Description("Pendiente")]
            Pendiente,

            [Description("En Selección")]
            Seleccion,

            [Description("Confirmada")]
            Confirmada,

            [Description("Disponible")]
            Disponible,

            [Description("Despachada")]
            Despachada,
            Seleccionada,
        }
    }
}