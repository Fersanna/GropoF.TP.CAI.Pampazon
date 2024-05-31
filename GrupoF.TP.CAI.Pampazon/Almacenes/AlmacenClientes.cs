using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    internal class AlmacenClientes
    {
        internal static List<ClienteEnt> Clientes { get; private set; }

        static AlmacenClientes()
        {
            Clientes = new List<ClienteEnt>();

            try
            {
                if (File.Exists("Clientes.json"))
                {
                    var archivoCargado = File.ReadAllText("Clientes.json");
                    Clientes = JsonConvert.DeserializeObject<List<ClienteEnt>>(archivoCargado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los clientes: {ex.Message}");
            }
        }

        public static void Grabar()
        {
            try
            {
                var contenidoJson = JsonConvert.SerializeObject(Clientes, Formatting.Indented);
                File.WriteAllText("Clientes.json", contenidoJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar los clientes: {ex.Message}");
            }
        }
    }
}
