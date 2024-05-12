﻿using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación;
using GrupoF.TP.CAI.Pampazon.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios
{
    public partial class GenerarOrdenDePreparacionForm : Form
    {
        public BuscarClienteModel model { get; set; }

        public GenerarOrdenDePreparacionForm(BuscarClienteModel model)
        {
            InitializeComponent();


        }

        private void GenerarOrdenDePreparacionForm_Load(object sender, EventArgs e)
        {


            ProductosList.Items.Clear();

            if (model.ClienteSeleccionado != null && model.ClienteSeleccionado.Productos != null)
            {
                foreach (Productos producto in model.ClienteSeleccionado.Productos)
                {
                    ListViewItem item = new ListViewItem(producto.IdProducto); // Usa el IdProducto como el primer texto del ítem.
                    item.SubItems.Add(producto.Descripcion); // Añade descripción como subítem.
                    item.SubItems.Add(producto.Posicion); // Añade posición como subítem.
                    item.SubItems.Add(producto.Cantidad.ToString()); // Añade cantidad como subítem, asegúrate de convertirlo a string si es necesario.

                    ProductosList.Items.Add(item); // Añade el ítem al ListView.

                    item.Tag = producto;
                }
            }
            else
            {
                MessageBox.Show("No hay productos para mostrar o el cliente no está seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void GenerarBtn_Click(object sender, EventArgs e)
        {


            OrdenDePreparacionForm ordenDePreparacionForm = new OrdenDePreparacionForm();
            ordenDePreparacionForm.model = model;
            ordenDePreparacionForm.ShowDialog();

        }

        private void PorductosList_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        public void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (ProductosList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ProductosList.SelectedItems[0];
                Productos selectedProducto = (Productos)selectedItem.Tag;

                bool productoExiste = false;

                foreach (DataGridViewRow row in EditarOrden_GridView.Rows)
                {
                    if (!row.IsNewRow && row.Cells["IdProducto"].Value.ToString() == selectedProducto.IdProducto)
                    {
                        productoExiste = true;
                        MessageBox.Show("Este producto ya está agregado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (!productoExiste)
                {
                    // Crear una nueva fila en el DataGridView
                    int rowIndex = EditarOrden_GridView.Rows.Add();
                    DataGridViewRow newRow = EditarOrden_GridView.Rows[rowIndex];


                    newRow.Cells["IdProducto"].Value = selectedProducto.IdProducto;
                    newRow.Cells["Descripcion"].Value = selectedProducto.Descripcion;
                    newRow.Cells["Posicion"].Value = selectedProducto.Posicion;
                    newRow.Cells["Cantidad"].Value = selectedProducto.Cantidad;  // Inicialmente usa la cantidad máxima disponible




                    EditarOrden_GridView.BeginEdit(true);

                    if (model.ClienteOrden == null)
                    {
                        model.ClienteOrden = new OrdenDeSeleccion();
                        model.ClienteOrden.CodigoCliente = model.ClienteOrden.CodigoCliente;
                        model.ClienteOrden.ProductosOrden = new List<Productos>();
                    }

                    // Añadir el producto seleccionado a la lista de productos en ClienteOrden
                    model.ClienteOrden.ProductosOrden.Add(new Productos()
                    {
                        IdProducto = (string)newRow.Cells["IdProducto"].Value,
                        Descripcion = (string)newRow.Cells["Descripcion"].Value,
                        Posicion = (string)newRow.Cells["Posicion"].Value,
                        Cantidad = (int)newRow.Cells["Cantidad"].Value,
                    });

                    MessageBox.Show("Se han agregado " + model.ClienteOrden.ProductosOrden.Count() + "a la orden");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void EditarOrden_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}





