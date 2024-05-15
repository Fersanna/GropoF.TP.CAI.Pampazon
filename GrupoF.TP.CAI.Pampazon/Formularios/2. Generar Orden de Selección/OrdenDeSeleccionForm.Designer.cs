namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    partial class OrdenDeSeleccionForm
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
            GenerarBtn = new Button();
            button1 = new Button();
            listView1 = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(521, 283);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(100, 27);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(627, 283);
            button1.Name = "button1";
            button1.Size = new Size(100, 27);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listView1.GridLines = true;
            listView1.Location = new Point(58, 47);
            listView1.Name = "listView1";
            listView1.Size = new Size(669, 230);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 6;
            label1.Text = "Detalle de ordenes";
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 338);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(GenerarBtn);
            Name = "OrdenDeSeleccionForm";
            Text = "Orden de Seleccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button GenerarBtn;
        private Button button1;
        private ListView listView1;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader EstadoColum;
        private Label label1;
    }
}