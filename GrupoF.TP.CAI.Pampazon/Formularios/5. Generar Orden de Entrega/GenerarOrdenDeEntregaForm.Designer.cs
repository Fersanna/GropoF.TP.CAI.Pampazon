namespace GrupoF.TP.CAI.Pampazon
{
    partial class GenerarOrdenDeEntregaForm
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
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            TransportistaTextBox = new TextBox();
            NumeroOrdenTextBox = new TextBox();
            label4 = new Label();
            ClienteTextBox = new TextBox();
            label3 = new Label();
            HastadateTimePicker = new DateTimePicker();
            label2 = new Label();
            DesdeTimePicker = new DateTimePicker();
            FiltrarBtn = new Button();
            listOrdenesPreparacion = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(557, 471);
            ConfirmarBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(103, 36);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(666, 471);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(103, 36);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 137);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 8;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(474, 22);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 28;
            label6.Text = "Transportista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 22);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 27;
            label5.Text = "Cliente";
            // 
            // TransportistaTextBox
            // 
            TransportistaTextBox.Location = new Point(478, 45);
            TransportistaTextBox.Margin = new Padding(3, 4, 3, 4);
            TransportistaTextBox.Name = "TransportistaTextBox";
            TransportistaTextBox.Size = new Size(139, 27);
            TransportistaTextBox.TabIndex = 25;
            // 
            // NumeroOrdenTextBox
            // 
            NumeroOrdenTextBox.Location = new Point(628, 45);
            NumeroOrdenTextBox.Margin = new Padding(3, 4, 3, 4);
            NumeroOrdenTextBox.Name = "NumeroOrdenTextBox";
            NumeroOrdenTextBox.Size = new Size(139, 27);
            NumeroOrdenTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(635, 22);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 23;
            label4.Text = "Numero Orden";
            // 
            // ClienteTextBox
            // 
            ClienteTextBox.Location = new Point(328, 45);
            ClienteTextBox.Margin = new Padding(3, 4, 3, 4);
            ClienteTextBox.Name = "ClienteTextBox";
            ClienteTextBox.Size = new Size(139, 27);
            ClienteTextBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 22);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 21;
            label3.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            HastadateTimePicker.Format = DateTimePickerFormat.Short;
            HastadateTimePicker.Location = new Point(176, 45);
            HastadateTimePicker.Name = "HastadateTimePicker";
            HastadateTimePicker.Size = new Size(137, 27);
            HastadateTimePicker.TabIndex = 20;
            HastadateTimePicker.Value = new DateTime(2024, 5, 18, 15, 54, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 22);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 19;
            label2.Text = "Desde";
            // 
            // DesdeTimePicker
            // 
            DesdeTimePicker.Format = DateTimePickerFormat.Short;
            DesdeTimePicker.Location = new Point(41, 45);
            DesdeTimePicker.MinDate = new DateTime(2024, 5, 1, 0, 0, 0, 0);
            DesdeTimePicker.Name = "DesdeTimePicker";
            DesdeTimePicker.Size = new Size(129, 27);
            DesdeTimePicker.TabIndex = 18;
            DesdeTimePicker.Value = new DateTime(2024, 5, 18, 0, 0, 0, 0);
            // 
            // FiltrarBtn
            // 
            FiltrarBtn.Location = new Point(41, 84);
            FiltrarBtn.Margin = new Padding(3, 4, 3, 4);
            FiltrarBtn.Name = "FiltrarBtn";
            FiltrarBtn.Size = new Size(726, 31);
            FiltrarBtn.TabIndex = 17;
            FiltrarBtn.Text = "Filtrar";
            FiltrarBtn.UseVisualStyleBackColor = true;
            FiltrarBtn.Click += FiltrarBtn_Click_1;
            // 
            // listOrdenesPreparacion
            // 
            listOrdenesPreparacion.BackColor = SystemColors.Window;
            listOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listOrdenesPreparacion.FullRowSelect = true;
            listOrdenesPreparacion.GridLines = true;
            listOrdenesPreparacion.Location = new Point(39, 162);
            listOrdenesPreparacion.Margin = new Padding(3, 4, 3, 4);
            listOrdenesPreparacion.Name = "listOrdenesPreparacion";
            listOrdenesPreparacion.Size = new Size(728, 288);
            listOrdenesPreparacion.TabIndex = 30;
            listOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            listOrdenesPreparacion.View = View.Details;
            listOrdenesPreparacion.MouseClick += listOrdenesPreparacion_MouseClick;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "N.º Orden";
            NumeroColum.Width = 130;
            // 
            // ClienteColum
            // 
            ClienteColum.Text = "Cliente";
            ClienteColum.TextAlign = HorizontalAlignment.Center;
            ClienteColum.Width = 160;
            // 
            // FechaColum
            // 
            FechaColum.Text = "Fecha";
            FechaColum.TextAlign = HorizontalAlignment.Center;
            FechaColum.Width = 130;
            // 
            // TranspColum
            // 
            TranspColum.Text = "Transportista";
            TranspColum.TextAlign = HorizontalAlignment.Center;
            TranspColum.Width = 130;
            // 
            // EstadoColum
            // 
            EstadoColum.Tag = "";
            EstadoColum.Text = "Estado";
            EstadoColum.TextAlign = HorizontalAlignment.Center;
            EstadoColum.Width = 130;
            // 
            // GenerarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 534);
            Controls.Add(listOrdenesPreparacion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TransportistaTextBox);
            Controls.Add(NumeroOrdenTextBox);
            Controls.Add(label4);
            Controls.Add(ClienteTextBox);
            Controls.Add(label3);
            Controls.Add(HastadateTimePicker);
            Controls.Add(label2);
            Controls.Add(DesdeTimePicker);
            Controls.Add(FiltrarBtn);
            Controls.Add(label1);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarOrdenDeEntregaForm";
            Text = "Generar Orden de Entrega";
            Load += GenerarOrdenDeEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox TransportistaTextBox;
        private TextBox NumeroOrdenTextBox;
        private Label label4;
        private TextBox ClienteTextBox;
        private Label label3;
        private DateTimePicker HastadateTimePicker;
        private Label label2;
        private DateTimePicker DesdeTimePicker;
        private Button FiltrarBtn;
        private ListView listOrdenesPreparacion;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader EstadoColum;
    }
}