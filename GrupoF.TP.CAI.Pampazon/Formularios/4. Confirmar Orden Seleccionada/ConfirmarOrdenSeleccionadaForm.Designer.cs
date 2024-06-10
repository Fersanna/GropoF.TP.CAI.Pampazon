namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    partial class ConfirmarOrdenSeleccionadaForm
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
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            listOrdenesEnSeleccion = new ListView();
            NumeroColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label1 = new Label();
            DetalleHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(584, 400);
            ConfirmarBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(112, 41);
            ConfirmarBtn.TabIndex = 2;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(703, 400);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(112, 41);
            CancelarBtn.TabIndex = 3;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listOrdenesEnSeleccion
            // 
            listOrdenesEnSeleccion.Columns.AddRange(new ColumnHeader[] { NumeroColum, DetalleHeader, FechaColum, EstadoColum });
            listOrdenesEnSeleccion.FullRowSelect = true;
            listOrdenesEnSeleccion.GridLines = true;
            listOrdenesEnSeleccion.Location = new Point(46, 61);
            listOrdenesEnSeleccion.Margin = new Padding(3, 4, 3, 4);
            listOrdenesEnSeleccion.Name = "listOrdenesEnSeleccion";
            listOrdenesEnSeleccion.Size = new Size(764, 329);
            listOrdenesEnSeleccion.TabIndex = 6;
            listOrdenesEnSeleccion.UseCompatibleStateImageBehavior = false;
            listOrdenesEnSeleccion.View = View.Details;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "ID";
            NumeroColum.Width = 130;
            // 
            // FechaColum
            // 
            FechaColum.Text = "Fecha";
            FechaColum.TextAlign = HorizontalAlignment.Center;
            FechaColum.Width = 130;
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
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 7;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // DetalleHeader
            // 
            DetalleHeader.Text = "Detalle de Ordenes";
            DetalleHeader.Width = 200;
            // 
            // ConfirmarOrdenSeleccionadaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 496);
            Controls.Add(label1);
            Controls.Add(listOrdenesEnSeleccion);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConfirmarOrdenSeleccionadaForm";
            Text = "Confirmar Orden Seleccionada";
            Load += ConfirmarOrdenSeleccionadaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private ListView listOrdenesEnSeleccion;
        private ColumnHeader NumeroColum;
        private ColumnHeader FechaColum;
        private ColumnHeader EstadoColum;
        private Label label1;
        private ColumnHeader DetalleHeader;
    }
}