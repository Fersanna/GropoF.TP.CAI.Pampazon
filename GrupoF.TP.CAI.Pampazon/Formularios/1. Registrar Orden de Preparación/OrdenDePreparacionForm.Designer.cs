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
            CodigoTransBox = new TextBox();
            TransportistaBox = new Label();
            FechaBox = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            ProductosList = new ListView();
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            ClienteBox = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(400, 327);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(100, 26);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Cancelar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(290, 327);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(100, 26);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Confirmar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 135);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Detalle de productos";
            // 
            // CodigoTransBox
            // 
            CodigoTransBox.Location = new Point(136, 50);
            CodigoTransBox.Margin = new Padding(3, 2, 3, 2);
            CodigoTransBox.Name = "CodigoTransBox";
            CodigoTransBox.Size = new Size(110, 23);
            CodigoTransBox.TabIndex = 4;
            // 
            // TransportistaBox
            // 
            TransportistaBox.AutoSize = true;
            TransportistaBox.Location = new Point(390, 33);
            TransportistaBox.Name = "TransportistaBox";
            TransportistaBox.Size = new Size(74, 15);
            TransportistaBox.TabIndex = 6;
            TransportistaBox.Text = "Transportista";
            // 
            // FechaBox
            // 
            FechaBox.AutoSize = true;
            FechaBox.Location = new Point(262, 33);
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(38, 15);
            FechaBox.TabIndex = 9;
            FechaBox.Text = "Fecha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 50);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 33);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(390, 50);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 10;
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header });
            ProductosList.FullRowSelect = true;
            ProductosList.GridLines = true;
            ProductosList.Location = new Point(10, 153);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(490, 169);
            ProductosList.TabIndex = 12;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
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
            ClienteBox.Location = new Point(136, 33);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(44, 15);
            ClienteBox.TabIndex = 7;
            ClienteBox.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 50);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 5;
            // 
            // OrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 381);
            Controls.Add(ProductosList);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(FechaBox);
            Controls.Add(textBox2);
            Controls.Add(ClienteBox);
            Controls.Add(TransportistaBox);
            Controls.Add(textBox1);
            Controls.Add(CodigoTransBox);
            Controls.Add(label1);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
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
        private TextBox CodigoTransBox;
        private Label TransportistaBox;
        private Label FechaBox;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private ListView ProductosList;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
        private Label ClienteBox;
        private TextBox textBox1;
    }
}