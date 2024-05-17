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
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            listInventario = new ListView();
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            Cliente_Header = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(447, 335);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(102, 29);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(555, 335);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(102, 29);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listInventario
            // 
            listInventario.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header, Cliente_Header });
            listInventario.FullRowSelect = true;
            listInventario.GridLines = true;
            listInventario.Location = new Point(53, 61);
            listInventario.Name = "listInventario";
            listInventario.Size = new Size(604, 268);
            listInventario.TabIndex = 3;
            listInventario.UseCompatibleStateImageBehavior = false;
            listInventario.View = View.Details;
            // 
            // IdProducto_Header
            // 
            IdProducto_Header.Text = "Código Producto";
            IdProducto_Header.Width = 120;
            // 
            // Descripcion_Header
            // 
            Descripcion_Header.Text = "Descripción";
            Descripcion_Header.TextAlign = HorizontalAlignment.Center;
            Descripcion_Header.Width = 120;
            // 
            // Posicion_Header
            // 
            Posicion_Header.Text = "Posición";
            Posicion_Header.TextAlign = HorizontalAlignment.Center;
            Posicion_Header.Width = 120;
            // 
            // Cantidad_Header
            // 
            Cantidad_Header.Text = "Cantidad";
            Cantidad_Header.TextAlign = HorizontalAlignment.Center;
            Cantidad_Header.Width = 120;
            // 
            // Cliente_Header
            // 
            Cliente_Header.Text = "Cliente";
            Cliente_Header.TextAlign = HorizontalAlignment.Center;
            Cliente_Header.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 43);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 4;
            label1.Text = "Detalle de productos";
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 427);
            Controls.Add(label1);
            Controls.Add(listInventario);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Name = "InventarioForm";
            Text = "Inventario";
            Load += InventarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private ListView listInventario;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
        private ColumnHeader Cliente_Header;
        private Label label1;
    }
}