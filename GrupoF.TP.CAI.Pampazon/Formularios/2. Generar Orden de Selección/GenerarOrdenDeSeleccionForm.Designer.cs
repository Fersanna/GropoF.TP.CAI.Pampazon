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
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listOrdenesPendientes
            // 
            listOrdenesPendientes.BackColor = SystemColors.Window;
            listOrdenesPendientes.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listOrdenesPendientes.FullRowSelect = true;
            listOrdenesPendientes.GridLines = true;
            listOrdenesPendientes.Location = new Point(48, 159);
            listOrdenesPendientes.Margin = new Padding(3, 4, 3, 4);
            listOrdenesPendientes.Name = "listOrdenesPendientes";
            listOrdenesPendientes.Size = new Size(764, 288);
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
            // EstadoColum
            // 
            EstadoColum.Tag = "";
            EstadoColum.Text = "Estado";
            EstadoColum.TextAlign = HorizontalAlignment.Center;
            EstadoColum.Width = 130;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(623, 456);
            ConfirmarBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(91, 31);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(721, 456);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(91, 31);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // FiltrarBtn
            // 
            FiltrarBtn.Location = new Point(48, 79);
            FiltrarBtn.Margin = new Padding(3, 4, 3, 4);
            FiltrarBtn.Name = "FiltrarBtn";
            FiltrarBtn.Size = new Size(765, 31);
            FiltrarBtn.TabIndex = 3;
            FiltrarBtn.Text = "Filtrar";
            FiltrarBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 135);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 4;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // DesdeTimePicker
            // 
            DesdeTimePicker.Format = DateTimePickerFormat.Short;
            DesdeTimePicker.Location = new Point(48, 40);
            DesdeTimePicker.MinDate = new DateTime(2024, 5, 1, 0, 0, 0, 0);
            DesdeTimePicker.Name = "DesdeTimePicker";
            DesdeTimePicker.Size = new Size(129, 27);
            DesdeTimePicker.TabIndex = 5;
            DesdeTimePicker.Value = new DateTime(2024, 5, 18, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 17);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 6;
            label2.Text = "Desde";
            // 
            // HastadateTimePicker
            // 
            HastadateTimePicker.Format = DateTimePickerFormat.Short;
            HastadateTimePicker.Location = new Point(183, 40);
            HastadateTimePicker.Name = "HastadateTimePicker";
            HastadateTimePicker.Size = new Size(136, 27);
            HastadateTimePicker.TabIndex = 7;
            HastadateTimePicker.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 17);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 8;
            label3.Text = "Hasta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 40);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 27);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 17);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 10;
            label4.Text = "Cliente";
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 525);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(HastadateTimePicker);
            Controls.Add(label2);
            Controls.Add(DesdeTimePicker);
            Controls.Add(label1);
            Controls.Add(FiltrarBtn);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(listOrdenesPendientes);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBox1;
        private Label label4;
    }
}