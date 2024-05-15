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
            EliminarBtn = new Button();
            CancelarBtn = new Button();
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
            SuspendLayout();
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(544, 305);
            EliminarBtn.Margin = new Padding(3, 4, 3, 4);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(114, 35);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Cancelar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(424, 305);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(114, 35);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Confirmar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 49);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 3;
            label1.Text = "Detalle de productos";
            // 
            // ClienteNombreTextBox
            // 
            ClienteNombreTextBox.Enabled = false;
            ClienteNombreTextBox.Location = new Point(12, 262);
            ClienteNombreTextBox.Name = "ClienteNombreTextBox";
            ClienteNombreTextBox.Size = new Size(125, 27);
            ClienteNombreTextBox.TabIndex = 4;
            ClienteNombreTextBox.TextChanged += ClienteNombreTextBox_TextChanged;
            // 
            // TransportistaBox
            // 
            TransportistaBox.AutoSize = true;
            TransportistaBox.Location = new Point(12, 112);
            TransportistaBox.Name = "TransportistaBox";
            TransportistaBox.Size = new Size(94, 20);
            TransportistaBox.TabIndex = 6;
            TransportistaBox.Text = "Transportista";
            // 
            // FechaBox
            // 
            FechaBox.AutoSize = true;
            FechaBox.Location = new Point(12, 49);
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(47, 20);
            FechaBox.TabIndex = 9;
            FechaBox.Text = "Fecha";
            // 
            // CodigoClienteTextBox
            // 
            CodigoClienteTextBox.Enabled = false;
            CodigoClienteTextBox.Location = new Point(12, 196);
            CodigoClienteTextBox.Name = "CodigoClienteTextBox";
            CodigoClienteTextBox.Size = new Size(125, 27);
            CodigoClienteTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // TranspBox
            // 
            TranspBox.Location = new Point(12, 135);
            TranspBox.Name = "TranspBox";
            TranspBox.Size = new Size(121, 27);
            TranspBox.TabIndex = 10;
            // 
            // ProductosOrdenList
            // 
            ProductosOrdenList.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header });
            ProductosOrdenList.FullRowSelect = true;
            ProductosOrdenList.GridLines = true;
            ProductosOrdenList.Location = new Point(169, 73);
            ProductosOrdenList.Margin = new Padding(3, 4, 3, 4);
            ProductosOrdenList.Name = "ProductosOrdenList";
            ProductosOrdenList.Size = new Size(489, 224);
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
            ClienteBox.Location = new Point(12, 240);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(55, 20);
            ClienteBox.TabIndex = 7;
            ClienteBox.Text = "Cliente";
            // 
            // FechaPicker
            // 
            FechaPicker.Format = DateTimePickerFormat.Short;
            FechaPicker.Location = new Point(12, 73);
            FechaPicker.Name = "FechaPicker";
            FechaPicker.Size = new Size(121, 27);
            FechaPicker.TabIndex = 13;
            FechaPicker.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // OrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 367);
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
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenDePreparacionForm";
            Text = "Orden de Preparacion";
            Load += OrdenDePreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EliminarBtn;
        private Button CancelarBtn;
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
    }
}