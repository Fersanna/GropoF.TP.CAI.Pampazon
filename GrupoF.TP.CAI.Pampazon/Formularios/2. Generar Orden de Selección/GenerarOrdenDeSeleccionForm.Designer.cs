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
            listView1 = new ListView();
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
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            NumeroColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { FechaColum, TranspColum, ClienteColum, NumeroColum, EstadoColum });
            listView1.GridLines = true;
            listView1.Location = new Point(61, 156);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 268);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(586, 445);
            GenerarBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(91, 31);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Seleccionar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(697, 445);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(91, 31);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(704, 123);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 3;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 132);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 4;
            label1.Text = "Listado de Ordenes";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(61, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(61, 91);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(165, 27);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(586, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 9);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 9;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 61);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 11;
            label4.Text = "Deposito";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(586, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 9);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 12;
            label5.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 68);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 13;
            label2.Text = "Hasta";
            // 
            // FechaColum
            // 
            FechaColum.Text = "Fecha";
            FechaColum.Width = 150;
            // 
            // TranspColum
            // 
            TranspColum.Text = "Transportista";
            TranspColum.TextAlign = HorizontalAlignment.Center;
            TranspColum.Width = 150;
            // 
            // ClienteColum
            // 
            ClienteColum.Text = "Cliente";
            ClienteColum.TextAlign = HorizontalAlignment.Center;
            ClienteColum.Width = 150;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "Numero de Orden";
            NumeroColum.TextAlign = HorizontalAlignment.Center;
            NumeroColum.Width = 150;
            // 
            // EstadoColum
            // 
            EstadoColum.Text = "Estado";
            EstadoColum.TextAlign = HorizontalAlignment.Center;
            EstadoColum.Width = 150;
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 525);
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
            Margin = new Padding(3, 4, 3, 4);
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