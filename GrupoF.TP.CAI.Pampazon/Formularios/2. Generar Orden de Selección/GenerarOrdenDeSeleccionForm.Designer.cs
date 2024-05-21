namespace GrupoF.TP.CAI.Pampazon
{
    partial class GenerarOrdenDeSeleccionForm
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
            listOrdenesPendientes = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            FiltrarBtn = new Button();
            label1 = new Label();
            DesdeTimePicker = new DateTimePicker();
            label2 = new Label();
            HastadateTimePicker = new DateTimePicker();
            label3 = new Label();
            ClienteTextBox = new TextBox();
            label4 = new Label();
            IdTextBox = new TextBox();
            TransportistaTextBox = new TextBox();
            PrioridadTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // listOrdenesPendientes
            // 
            listOrdenesPendientes.BackColor = SystemColors.Window;
            listOrdenesPendientes.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listOrdenesPendientes.FullRowSelect = true;
            listOrdenesPendientes.GridLines = true;
            listOrdenesPendientes.Location = new Point(42, 119);
            listOrdenesPendientes.Name = "listOrdenesPendientes";
            listOrdenesPendientes.Size = new Size(769, 217);
            listOrdenesPendientes.TabIndex = 0;
            listOrdenesPendientes.UseCompatibleStateImageBehavior = false;
            listOrdenesPendientes.View = View.Details;
            listOrdenesPendientes.MouseClick += listOrdenesPendientes_MouseClick;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "ID";
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
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(645, 342);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(80, 23);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(731, 342);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(80, 23);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // FiltrarBtn
            // 
            FiltrarBtn.Location = new Point(42, 59);
            FiltrarBtn.Name = "FiltrarBtn";
            FiltrarBtn.Size = new Size(769, 23);
            FiltrarBtn.TabIndex = 3;
            FiltrarBtn.Text = "Filtrar";
            FiltrarBtn.UseVisualStyleBackColor = true;
            FiltrarBtn.Click += FiltrarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 101);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 4;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // DesdeTimePicker
            // 
            DesdeTimePicker.Format = DateTimePickerFormat.Short;
            DesdeTimePicker.Location = new Point(42, 30);
            DesdeTimePicker.Margin = new Padding(3, 2, 3, 2);
            DesdeTimePicker.MinDate = new DateTime(2024, 5, 1, 0, 0, 0, 0);
            DesdeTimePicker.Name = "DesdeTimePicker";
            DesdeTimePicker.Size = new Size(113, 23);
            DesdeTimePicker.TabIndex = 5;
            DesdeTimePicker.Value = new DateTime(2024, 5, 18, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 13);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Desde";
            // 
            // HastadateTimePicker
            // 
            HastadateTimePicker.Format = DateTimePickerFormat.Short;
            HastadateTimePicker.Location = new Point(160, 30);
            HastadateTimePicker.Margin = new Padding(3, 2, 3, 2);
            HastadateTimePicker.Name = "HastadateTimePicker";
            HastadateTimePicker.Size = new Size(120, 23);
            HastadateTimePicker.TabIndex = 7;
            HastadateTimePicker.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 13);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Hasta";
            // 
            // ClienteTextBox
            // 
            ClienteTextBox.Location = new Point(433, 30);
            ClienteTextBox.Name = "ClienteTextBox";
            ClienteTextBox.Size = new Size(122, 23);
            ClienteTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 13);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 10;
            label4.Text = "ID";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(304, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(122, 23);
            IdTextBox.TabIndex = 11;
            // 
            // TransportistaTextBox
            // 
            TransportistaTextBox.Location = new Point(561, 30);
            TransportistaTextBox.Name = "TransportistaTextBox";
            TransportistaTextBox.Size = new Size(122, 23);
            TransportistaTextBox.TabIndex = 12;
            // 
            // PrioridadTextBox
            // 
            PrioridadTextBox.Location = new Point(689, 30);
            PrioridadTextBox.Name = "PrioridadTextBox";
            PrioridadTextBox.Size = new Size(122, 23);
            PrioridadTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 13);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 14;
            label5.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(561, 13);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 15;
            label6.Text = "Transportista";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(689, 13);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "Prioridad";
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 394);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(PrioridadTextBox);
            Controls.Add(TransportistaTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label4);
            Controls.Add(ClienteTextBox);
            Controls.Add(label3);
            Controls.Add(HastadateTimePicker);
            Controls.Add(label2);
            Controls.Add(DesdeTimePicker);
            Controls.Add(label1);
            Controls.Add(FiltrarBtn);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(listOrdenesPendientes);
            Name = "GenerarOrdenDeSeleccionForm";
            Text = "Generar Orden de Selección";
            Load += GenerarOrdenDeSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listOrdenesPendientes;
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private Button FiltrarBtn;
        private Label label1;
        private DateTimePicker DesdeTimePicker;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader NumeroColum;
        private ColumnHeader EstadoColum;
        private Label label2;
        private DateTimePicker HastadateTimePicker;
        private Label label3;
        private TextBox ClienteTextBox;
        private Label label4;
        private TextBox IdTextBox;
        private TextBox TransportistaTextBox;
        private TextBox PrioridadTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}