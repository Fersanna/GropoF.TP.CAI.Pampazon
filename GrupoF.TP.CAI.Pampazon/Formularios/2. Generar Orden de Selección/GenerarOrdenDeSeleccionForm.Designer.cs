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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listOrdenesPendientes
            // 
            listOrdenesPendientes.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listOrdenesPendientes.FullRowSelect = true;
            listOrdenesPendientes.GridLines = true;
            listOrdenesPendientes.Location = new Point(42, 119);
            listOrdenesPendientes.Name = "listOrdenesPendientes";
            listOrdenesPendientes.Size = new Size(669, 217);
            listOrdenesPendientes.TabIndex = 0;
            listOrdenesPendientes.UseCompatibleStateImageBehavior = false;
            listOrdenesPendientes.View = View.Details;
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
            ConfirmarBtn.Location = new Point(545, 342);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(80, 23);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(631, 342);
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
            FiltrarBtn.Size = new Size(669, 23);
            FiltrarBtn.TabIndex = 3;
            FiltrarBtn.Text = "Filtrar";
            FiltrarBtn.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(42, 30);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(269, 30);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(199, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 13);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Hasta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(589, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 13);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Cliente";
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 394);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader NumeroColum;
        private ColumnHeader EstadoColum;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
    }
}