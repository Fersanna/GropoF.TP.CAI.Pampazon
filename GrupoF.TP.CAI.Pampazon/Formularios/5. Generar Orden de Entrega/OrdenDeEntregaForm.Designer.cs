namespace GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega
{
    partial class OrdenDeEntregaForm
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
            CancelarBtn = new Button();
            listOrdenesSeleccionadasConfirmadas = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label1 = new Label();
            GenerarBtn = new Button();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(673, 393);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(120, 40);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listOrdenesSeleccionadasConfirmadas
            // 
            listOrdenesSeleccionadasConfirmadas.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listOrdenesSeleccionadasConfirmadas.GridLines = true;
            listOrdenesSeleccionadasConfirmadas.Location = new Point(31, 60);
            listOrdenesSeleccionadasConfirmadas.Margin = new Padding(3, 4, 3, 4);
            listOrdenesSeleccionadasConfirmadas.Name = "listOrdenesSeleccionadasConfirmadas";
            listOrdenesSeleccionadasConfirmadas.Size = new Size(762, 311);
            listOrdenesSeleccionadasConfirmadas.TabIndex = 6;
            listOrdenesSeleccionadasConfirmadas.UseCompatibleStateImageBehavior = false;
            listOrdenesSeleccionadasConfirmadas.View = View.Details;
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
            EstadoColum.Text = "Estado";
            EstadoColum.TextAlign = HorizontalAlignment.Center;
            EstadoColum.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 7;
            label1.Text = "Detalle de ordenes";
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(546, 393);
            GenerarBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(120, 40);
            GenerarBtn.TabIndex = 8;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // OrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 488);
            Controls.Add(GenerarBtn);
            Controls.Add(label1);
            Controls.Add(listOrdenesSeleccionadasConfirmadas);
            Controls.Add(CancelarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenDeEntregaForm";
            Text = "Orden de Entrega";
            Load += OrdenDeEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelarBtn;
        private ListView listOrdenesSeleccionadasConfirmadas;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private Label label1;
        private ColumnHeader EstadoColum;
        private Button GenerarBtn;
    }
}