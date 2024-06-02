using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    public static class AlmacenClientes
    {
        public static List<ClienteEnt> Clientes { get; private set; }
        private static readonly string filePath = @"C:\Users\Administrator\Desktop\Tp.CAI\GropoF.TP.CAI.Pampazon\GrupoF.TP.CAI.Pampazon\Json\Clientes.json";
        static AlmacenClientes()
        {
            Clientes = new List<ClienteEnt>();

            try
            {
                if (File.Exists(filePath))
                {
                    var archivoCargado = File.ReadAllText(filePath);
                     MessageBox.Show ("Archivo cargado correctamente.");
                    Clientes = JsonConvert.DeserializeObject<List<ClienteEnt>>(archivoCargado);
                   
                }
                else
                {
                    MessageBox.Show ("El archivo Clientes.json no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"Error al cargar los clientes: {ex.Message}");
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
               MessageBox.Show ($"Error al guardar los clientes: {ex.Message}");
            }
        }
    }
}
