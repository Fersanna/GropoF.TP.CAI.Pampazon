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
            CancelarBtn = new Button();
            ListOrdenesSeleccionConfirmadas = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label1 = new Label();
            PrioridadColum = new ColumnHeader();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(591, 324);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(100, 27);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(697, 324);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(100, 27);
            CancelarBtn.TabIndex = 4;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += Cancelar_Click;
            // 
            // ListOrdenesSeleccionConfirmadas
            // 
            ListOrdenesSeleccionConfirmadas.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, PrioridadColum, EstadoColum });
            ListOrdenesSeleccionConfirmadas.GridLines = true;
            ListOrdenesSeleccionConfirmadas.Location = new Point(29, 51);
            ListOrdenesSeleccionConfirmadas.Name = "ListOrdenesSeleccionConfirmadas";
            ListOrdenesSeleccionConfirmadas.Size = new Size(768, 267);
            ListOrdenesSeleccionConfirmadas.TabIndex = 5;
            ListOrdenesSeleccionConfirmadas.UseCompatibleStateImageBehavior = false;
            ListOrdenesSeleccionConfirmadas.View = View.Details;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "ID";
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
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 6;
            label1.Text = "Detalle de ordenes";
            // 
            // PrioridadColum
            // 
            PrioridadColum.Text = "Prioridad";
            PrioridadColum.TextAlign = HorizontalAlignment.Center;
            PrioridadColum.Width = 130;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 381);
            Controls.Add(label1);
            Controls.Add(ListOrdenesSeleccionConfirmadas);
            Controls.Add(CancelarBtn);
            Controls.Add(GenerarBtn);
            Name = "OrdenDeSeleccionForm";
            Text = "Orden de Seleccion";
            Load += OrdenDeSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button GenerarBtn;
        private Button CancelarBtn;
        private ListView ListOrdenesSeleccionConfirmadas;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader EstadoColum;
        private Label label1;
        private ColumnHeader PrioridadColum;
    }
}