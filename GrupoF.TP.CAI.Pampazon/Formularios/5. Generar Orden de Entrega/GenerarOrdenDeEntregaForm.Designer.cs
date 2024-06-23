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
            PrioridadColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label7 = new Label();
            PrioridadTextBox = new TextBox();
            LimpiarBtn = new Button();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(620, 345);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(90, 27);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(716, 345);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(90, 27);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 103);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 8;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 16);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 28;
            label6.Text = "Transportista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 16);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 27;
            label5.Text = "Cliente";
            // 
            // TransportistaTextBox
            // 
            TransportistaTextBox.Location = new Point(422, 34);
            TransportistaTextBox.Name = "TransportistaTextBox";
            TransportistaTextBox.Size = new Size(122, 23);
            TransportistaTextBox.TabIndex = 25;
            // 
            // NumeroOrdenTextBox
            // 
            NumeroOrdenTextBox.Location = new Point(554, 34);
            NumeroOrdenTextBox.Name = "NumeroOrdenTextBox";
            NumeroOrdenTextBox.Size = new Size(122, 23);
            NumeroOrdenTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 16);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 23;
            label4.Text = "Numero Orden";
            // 
            // ClienteTextBox
            // 
            ClienteTextBox.Location = new Point(291, 34);
            ClienteTextBox.Name = "ClienteTextBox";
            ClienteTextBox.Size = new Size(122, 23);
            ClienteTextBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 16);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 21;
            label3.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            HastadateTimePicker.Format = DateTimePickerFormat.Short;
            HastadateTimePicker.Location = new Point(154, 34);
            HastadateTimePicker.Margin = new Padding(3, 2, 3, 2);
            HastadateTimePicker.Name = "HastadateTimePicker";
            HastadateTimePicker.Size = new Size(120, 23);
            HastadateTimePicker.TabIndex = 20;
            HastadateTimePicker.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 19;
            label2.Text = "Desde";
            // 
            // DesdeTimePicker
            // 
            DesdeTimePicker.Format = DateTimePickerFormat.Short;
            DesdeTimePicker.Location = new Point(36, 34);
            DesdeTimePicker.Margin = new Padding(3, 2, 3, 2);
            DesdeTimePicker.MinDate = new DateTime(2024, 5, 1, 0, 0, 0, 0);
            DesdeTimePicker.Name = "DesdeTimePicker";
            DesdeTimePicker.Size = new Size(113, 23);
            DesdeTimePicker.TabIndex = 18;
            DesdeTimePicker.Value = new DateTime(2024, 5, 18, 0, 0, 0, 0);
            // 
            // FiltrarBtn
            // 
            FiltrarBtn.Location = new Point(36, 63);
            FiltrarBtn.Name = "FiltrarBtn";
            FiltrarBtn.Size = new Size(574, 23);
            FiltrarBtn.TabIndex = 17;
            FiltrarBtn.Text = "Filtrar";
            FiltrarBtn.UseVisualStyleBackColor = true;
            FiltrarBtn.Click += FiltrarBtn_Click_1;
            // 
            // listOrdenesPreparacion
            // 
            listOrdenesPreparacion.BackColor = SystemColors.Window;
            listOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, PrioridadColum, EstadoColum });
            listOrdenesPreparacion.FullRowSelect = true;
            listOrdenesPreparacion.GridLines = true;
            listOrdenesPreparacion.Location = new Point(34, 122);
            listOrdenesPreparacion.MultiSelect = false;
            listOrdenesPreparacion.Name = "listOrdenesPreparacion";
            listOrdenesPreparacion.Size = new Size(771, 217);
            listOrdenesPreparacion.TabIndex = 30;
            listOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            listOrdenesPreparacion.View = View.Details;
            listOrdenesPreparacion.MouseClick += listOrdenesPreparacion_MouseClick;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "N.º Orden";
            NumeroColum.Width = 110;
            // 
            // ClienteColum
            // 
            ClienteColum.Text = "Cliente";
            ClienteColum.TextAlign = HorizontalAlignment.Center;
            ClienteColum.Width = 130;
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
            // PrioridadColum
            // 
            PrioridadColum.Text = "Prioridad";
            PrioridadColum.TextAlign = HorizontalAlignment.Center;
            PrioridadColum.Width = 130;
            // 
            // EstadoColum
            // 
            EstadoColum.Tag = "";
            EstadoColum.Text = "Estado";
            EstadoColum.TextAlign = HorizontalAlignment.Center;
            EstadoColum.Width = 130;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(684, 17);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 32;
            label7.Text = "Prioridad";
            // 
            // PrioridadTextBox
            // 
            PrioridadTextBox.Location = new Point(682, 34);
            PrioridadTextBox.Name = "PrioridadTextBox";
            PrioridadTextBox.Size = new Size(122, 23);
            PrioridadTextBox.TabIndex = 31;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(620, 63);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(184, 23);
            LimpiarBtn.TabIndex = 33;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += LimpiarBtn_Click;
            // 
            // GenerarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 400);
            Controls.Add(LimpiarBtn);
            Controls.Add(label7);
            Controls.Add(PrioridadTextBox);
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
        private ColumnHeader PrioridadColum;
        private Label label7;
        private TextBox PrioridadTextBox;
        private Button LimpiarBtn;
    }
}