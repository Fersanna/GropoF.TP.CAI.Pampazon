namespace GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación
{
    partial class OrdenDePreparacionForm
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
            ConfirmarPrepBtn = new Button();
            CancelarOrdenBtn = new Button();
            label1 = new Label();
            ClienteNombreTextBox = new TextBox();
            TransportistaBox = new Label();
            FechaBox = new Label();
            CodigoClienteTextBox = new TextBox();
            label2 = new Label();
            TranspBox = new TextBox();
            ProductosOrdenList = new ListView();
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            ClienteBox = new Label();
            FechaPicker = new DateTimePicker();
            PrioridadBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // ConfirmarPrepBtn
            // 
            ConfirmarPrepBtn.Location = new Point(434, 279);
            ConfirmarPrepBtn.Name = "ConfirmarPrepBtn";
            ConfirmarPrepBtn.Size = new Size(100, 26);
            ConfirmarPrepBtn.TabIndex = 1;
            ConfirmarPrepBtn.Text = "Confirmar";
            ConfirmarPrepBtn.UseVisualStyleBackColor = true;
            ConfirmarPrepBtn.Click += ConfirmarPrepBtn_Click;
            // 
            // CancelarOrdenBtn
            // 
            CancelarOrdenBtn.Location = new Point(540, 279);
            CancelarOrdenBtn.Name = "CancelarOrdenBtn";
            CancelarOrdenBtn.Size = new Size(100, 26);
            CancelarOrdenBtn.TabIndex = 2;
            CancelarOrdenBtn.Text = "Cancelar";
            CancelarOrdenBtn.UseVisualStyleBackColor = true;
            CancelarOrdenBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 37);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Detalle de productos";
            // 
            // ClienteNombreTextBox
            // 
            ClienteNombreTextBox.Enabled = false;
            ClienteNombreTextBox.Location = new Point(10, 245);
            ClienteNombreTextBox.Margin = new Padding(3, 2, 3, 2);
            ClienteNombreTextBox.Name = "ClienteNombreTextBox";
            ClienteNombreTextBox.Size = new Size(133, 23);
            ClienteNombreTextBox.TabIndex = 4;
            ClienteNombreTextBox.TextChanged += ClienteNombreTextBox_TextChanged;
            // 
            // TransportistaBox
            // 
            TransportistaBox.AutoSize = true;
            TransportistaBox.Location = new Point(10, 84);
            TransportistaBox.Name = "TransportistaBox";
            TransportistaBox.Size = new Size(74, 15);
            TransportistaBox.TabIndex = 6;
            TransportistaBox.Text = "Transportista";
            // 
            // FechaBox
            // 
            FechaBox.AutoSize = true;
            FechaBox.Location = new Point(10, 37);
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(38, 15);
            FechaBox.TabIndex = 9;
            FechaBox.Text = "Fecha";
            // 
            // CodigoClienteTextBox
            // 
            CodigoClienteTextBox.Enabled = false;
            CodigoClienteTextBox.Location = new Point(10, 196);
            CodigoClienteTextBox.Margin = new Padding(3, 2, 3, 2);
            CodigoClienteTextBox.Name = "CodigoClienteTextBox";
            CodigoClienteTextBox.Size = new Size(133, 23);
            CodigoClienteTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 179);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // TranspBox
            // 
            TranspBox.Location = new Point(10, 101);
            TranspBox.Margin = new Padding(3, 2, 3, 2);
            TranspBox.Name = "TranspBox";
            TranspBox.Size = new Size(133, 23);
            TranspBox.TabIndex = 10;
            // 
            // ProductosOrdenList
            // 
            ProductosOrdenList.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header });
            ProductosOrdenList.FullRowSelect = true;
            ProductosOrdenList.GridLines = true;
            ProductosOrdenList.Location = new Point(148, 55);
            ProductosOrdenList.Name = "ProductosOrdenList";
            ProductosOrdenList.Size = new Size(492, 214);
            ProductosOrdenList.TabIndex = 12;
            ProductosOrdenList.UseCompatibleStateImageBehavior = false;
            ProductosOrdenList.View = View.Details;
            ProductosOrdenList.SelectedIndexChanged += ProductosOrdenList_SelectedIndexChanged;
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
            // ClienteBox
            // 
            ClienteBox.AutoSize = true;
            ClienteBox.Location = new Point(10, 229);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(44, 15);
            ClienteBox.TabIndex = 7;
            ClienteBox.Text = "Cliente";
            // 
            // FechaPicker
            // 
            FechaPicker.Format = DateTimePickerFormat.Short;
            FechaPicker.Location = new Point(10, 55);
            FechaPicker.Margin = new Padding(3, 2, 3, 2);
            FechaPicker.Name = "FechaPicker";
            FechaPicker.Size = new Size(133, 23);
            FechaPicker.TabIndex = 13;
            FechaPicker.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // PrioridadBox
            // 
            PrioridadBox.Location = new Point(10, 149);
            PrioridadBox.Margin = new Padding(3, 2, 3, 2);
            PrioridadBox.Name = "PrioridadBox";
            PrioridadBox.Size = new Size(133, 23);
            PrioridadBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 132);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 15;
            label3.Text = "Prioridad";
            // 
            // OrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 328);
            Controls.Add(label3);
            Controls.Add(PrioridadBox);
            Controls.Add(FechaPicker);
            Controls.Add(ProductosOrdenList);
            Controls.Add(label2);
            Controls.Add(TranspBox);
            Controls.Add(FechaBox);
            Controls.Add(CodigoClienteTextBox);
            Controls.Add(ClienteBox);
            Controls.Add(TransportistaBox);
            Controls.Add(ClienteNombreTextBox);
            Controls.Add(label1);
            Controls.Add(CancelarOrdenBtn);
            Controls.Add(ConfirmarPrepBtn);
            Name = "OrdenDePreparacionForm";
            Text = "Orden de Preparacion";
            Load += OrdenDePreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarPrepBtn;
        private Button CancelarOrdenBtn;
        private Label label1;
        private TextBox ClienteNombreTextBox;
        private Label TransportistaBox;
        private Label FechaBox;
        private TextBox CodigoClienteTextBox;
        private Label label2;
        private TextBox TranspBox;
        private ListView ProductosOrdenList;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
        private Label ClienteBox;
        private DateTimePicker FechaPicker;
        private TextBox PrioridadBox;
        private Label label3;
    }
}