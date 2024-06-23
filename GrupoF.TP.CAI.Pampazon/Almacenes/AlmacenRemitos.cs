using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    internal class AlmacenRemitos
    {
       
        public static List<RemitosEnt> RemitosEnt { get; private set; }

         static AlmacenRemitos()
        {
            RemitosEnt = new List<RemitosEnt>();

            try
            {
                if (File.Exists(@"Json\Remitos.json"))
                {
                    var archivoCargado = File.ReadAllText(@"Json\Remitos.json");
                    var remitos = JsonConvert.DeserializeObject<List<RemitosEnt>>(archivoCargado);
                    if (remitos != null)
                    {
                        RemitosEnt = remitos;
                    }

                  
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las órdenes de selección: {ex.Message}");
            }
        }

         public static void Grabar()
        {
            try
            {
                var contenidoJson = JsonConvert.SerializeObject(RemitosEnt, Formatting.Indented);
                File.WriteAllText(@"Json\Remitos.json", contenidoJson);
                MessageBox.Show("Remito guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el remito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}
