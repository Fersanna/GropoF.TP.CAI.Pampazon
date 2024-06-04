using GrupoF.TP.CAI.Pampazon.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.TP.CAI.Pampazon.Almacenes
{
    internal class AlmacenProductos
    {
         public static List<ProductoEnt> Productos { get; private set; }
        private static readonly string filePath = @"Json\Productos.json";

        static AlmacenProductos()
        {
            Productos = new List<ProductoEnt>();

            try
            {
                if (File.Exists(filePath))
                {
                    var archivoCargado = File.ReadAllText(filePath);
                   
                    Productos = JsonConvert.DeserializeObject<List<ProductoEnt>>(archivoCargado);
                }
                else
                {
                    MessageBox.Show("El archivo Productos.json no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }

        public static void Grabar()
        {
            try
            {
                var contenidoJson = JsonConvert.SerializeObject(Productos, Formatting.Indented);
                File.WriteAllText(filePath, contenidoJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los productos: {ex.Message}");
            }
        }
    }
}
