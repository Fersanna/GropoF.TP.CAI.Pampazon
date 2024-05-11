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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "P-000001", "01", "13/05/24", "Express Cargo", "Pendiente" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "P-000002", "02", "13/05/24", "Logística Global", "Pendiente" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "P-000003", "03", "15/05/24", "Transportes XYZ", "Pendiente" }, -1);
            listView1 = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            GenerarBtn = new Button();
            CancelarBtn = new Button();
            button1 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(53, 117);
            listView1.Name = "listView1";
            listView1.Size = new Size(669, 202);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(547, 334);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(80, 23);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Seleccionar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(642, 334);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(80, 23);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(642, 88);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 3;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 99);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 4;
            label1.Text = "Listado de Ordenes";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(53, 22);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(145, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(53, 68);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(145, 23);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(337, 28);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 12);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 51);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 11;
            label4.Text = "Deposito";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 67);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 7);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 12;
            label5.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 51);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 13;
            label2.Text = "Hasta";
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 394);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(CancelarBtn);
            Controls.Add(GenerarBtn);
            Controls.Add(listView1);
            Name = "GenerarOrdenDeSeleccionForm";
            Text = "Generar Orden de Selección";
            Load += GenerarOrdenDeSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button GenerarBtn;
        private Button CancelarBtn;
        private Button button1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label2;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader NumeroColum;
        private ColumnHeader EstadoColum;
    }
}