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
            label4 = new Label();
            PrioridadBox = new TextBox();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(594, 432);
            GenerarBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(114, 36);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(715, 432);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(114, 36);
            CancelarBtn.TabIndex = 4;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += Cancelar_Click;
            // 
            // ListOrdenesSeleccionConfirmadas
            // 
            ListOrdenesSeleccionConfirmadas.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            ListOrdenesSeleccionConfirmadas.GridLines = true;
            ListOrdenesSeleccionConfirmadas.Location = new Point(65, 117);
            ListOrdenesSeleccionConfirmadas.Margin = new Padding(3, 4, 3, 4);
            ListOrdenesSeleccionConfirmadas.Name = "ListOrdenesSeleccionConfirmadas";
            ListOrdenesSeleccionConfirmadas.Size = new Size(764, 305);
            ListOrdenesSeleccionConfirmadas.TabIndex = 5;
            ListOrdenesSeleccionConfirmadas.UseCompatibleStateImageBehavior = false;
            ListOrdenesSeleccionConfirmadas.View = View.Details;
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
            label1.Location = new Point(65, 93);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 6;
            label1.Text = "Detalle de ordenes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 40);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 48;
            label4.Text = "Prioridad";
            // 
            // PrioridadBox
            // 
            PrioridadBox.Location = new Point(135, 36);
            PrioridadBox.Margin = new Padding(3, 4, 3, 4);
            PrioridadBox.Name = "PrioridadBox";
            PrioridadBox.Size = new Size(116, 27);
            PrioridadBox.TabIndex = 47;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 508);
            Controls.Add(label4);
            Controls.Add(PrioridadBox);
            Controls.Add(label1);
            Controls.Add(ListOrdenesSeleccionConfirmadas);
            Controls.Add(CancelarBtn);
            Controls.Add(GenerarBtn);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label4;
        private TextBox PrioridadBox;
    }
}