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
            NumeroHeader = new ColumnHeader();
            FechaHeader = new ColumnHeader();
            ClienteHeader = new ColumnHeader();
            TranspHeader = new ColumnHeader();
            EstadoHeader = new ColumnHeader();
            PrioriodadHeader = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(606, 300);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(98, 31);
            ConfirmarBtn.TabIndex = 2;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(710, 300);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(98, 31);
            CancelarBtn.TabIndex = 3;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listOrdenesEnSeleccion
            // 
            listOrdenesEnSeleccion.Columns.AddRange(new ColumnHeader[] { NumeroHeader, ClienteHeader, FechaHeader, TranspHeader, PrioriodadHeader, EstadoHeader });
            listOrdenesEnSeleccion.FullRowSelect = true;
            listOrdenesEnSeleccion.GridLines = true;
            listOrdenesEnSeleccion.Location = new Point(40, 46);
            listOrdenesEnSeleccion.MultiSelect = false;
            listOrdenesEnSeleccion.Name = "listOrdenesEnSeleccion";
            listOrdenesEnSeleccion.Size = new Size(768, 248);
            listOrdenesEnSeleccion.TabIndex = 6;
            listOrdenesEnSeleccion.UseCompatibleStateImageBehavior = false;
            listOrdenesEnSeleccion.View = View.Details;
            listOrdenesEnSeleccion.MouseClick += listOrdenesEnSeleccion_MouseClick;
            // 
            // NumeroHeader
            // 
            NumeroHeader.Text = "ID";
            NumeroHeader.Width = 110;
            // 
            // FechaHeader
            // 
            FechaHeader.Text = "Fecha";
            FechaHeader.TextAlign = HorizontalAlignment.Center;
            FechaHeader.Width = 130;
            // 
            // ClienteHeader
            // 
            ClienteHeader.Text = "Cliente";
            ClienteHeader.TextAlign = HorizontalAlignment.Center;
            ClienteHeader.Width = 130;
            // 
            // TranspHeader
            // 
            TranspHeader.Text = "Transportista";
            TranspHeader.TextAlign = HorizontalAlignment.Center;
            TranspHeader.Width = 130;
            // 
            // EstadoHeader
            // 
            EstadoHeader.Text = "Estado";
            EstadoHeader.TextAlign = HorizontalAlignment.Center;
            EstadoHeader.Width = 130;
            // 
            // PrioriodadHeader
            // 
            PrioriodadHeader.Text = "Prioridad";
            PrioriodadHeader.TextAlign = HorizontalAlignment.Center;
            PrioriodadHeader.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 7;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // ConfirmarOrdenSeleccionadaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 372);
            Controls.Add(label1);
            Controls.Add(listOrdenesEnSeleccion);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
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
        private ColumnHeader NumeroHeader;
        private ColumnHeader EstadoHeader;
        private Label label1;
        private ColumnHeader ClienteHeader;
        private ColumnHeader FechaHeader;
        private ColumnHeader TranspHeader;
        private ColumnHeader PrioriodadHeader;
    }
}