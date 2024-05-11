namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    partial class InventarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "01", "Sillas", "12-43-2", "18", "01" }, -1);
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            ProductosList = new ListView();
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(624, 357);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(102, 29);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(516, 357);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(102, 29);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header, columnHeader1 });
            ProductosList.FullRowSelect = true;
            ProductosList.GridLines = true;
            ProductosList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            ProductosList.Location = new Point(53, 61);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(673, 268);
            ProductosList.TabIndex = 3;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            // 
            // IdProducto_Header
            // 
            IdProducto_Header.Text = "Codigo Producto";
            IdProducto_Header.Width = 120;
            // 
            // Descripcion_Header
            // 
            Descripcion_Header.Text = "Descripcion";
            Descripcion_Header.TextAlign = HorizontalAlignment.Center;
            Descripcion_Header.Width = 120;
            // 
            // Posicion_Header
            // 
            Posicion_Header.Text = "Posicion";
            Posicion_Header.TextAlign = HorizontalAlignment.Center;
            Posicion_Header.Width = 120;
            // 
            // Cantidad_Header
            // 
            Cantidad_Header.Text = "Cantidad";
            Cantidad_Header.TextAlign = HorizontalAlignment.Center;
            Cantidad_Header.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cliente";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 120;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductosList);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Name = "InventarioForm";
            Text = "Inventario";
            ResumeLayout(false);
        }

        #endregion
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private ListView ProductosList;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
        private ColumnHeader columnHeader1;
    }
}