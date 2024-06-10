using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Entidades
{
    public class OrdenDeSeleccionEnt
    {
       
        public string IdOrdenDeSeleccion {get; set; }

        //No tiene un estado?

        public List<string> CodigosOrdenesPreparacion {get; set;} //Es una lista de códigos de ordenes de preparación
    }
}
