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
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "P-000001", "01", "13/05/24", "Express Cargo", "Pendiente" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "P-000002", "02", "13/05/24", "Logística Global", "Pendiente" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "P-000003", "03", "14/05/24", "Transportes XYZ", "Pendiente" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "P-000004", "02", "15/05/24", "Logística Global", "Pendiente" }, -1);
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
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            listView1.Location = new Point(42, 134);
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
            GenerarBtn.Location = new Point(545, 342);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(80, 23);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Confirmar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
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
            // button1
            // 
            button1.Location = new Point(42, 68);
            button1.Name = "button1";
            button1.Size = new Size(669, 23);
            button1.TabIndex = 3;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 116);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 4;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(42, 38);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 5, 10, 15, 54, 23, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 21);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 394);
            Controls.Add(label2);
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
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader NumeroColum;
        private ColumnHeader EstadoColum;
        private Label label2;
    }
}