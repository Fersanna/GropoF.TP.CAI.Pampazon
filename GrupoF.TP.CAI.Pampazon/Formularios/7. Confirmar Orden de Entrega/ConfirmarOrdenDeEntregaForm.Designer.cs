namespace GrupoF.TP.CAI.Pampazon
{
    partial class ConfirmarOrdenDeEntregaForm
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
            listOrdenesPreparadas = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            PrioridadColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label1 = new Label();
            SiguienteBtn = new Button();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(601, 294);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(103, 26);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(710, 294);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(103, 26);
            CancelarBtn.TabIndex = 3;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listOrdenesPreparadas
            // 
            listOrdenesPreparadas.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, PrioridadColum, EstadoColum });
            listOrdenesPreparadas.FullRowSelect = true;
            listOrdenesPreparadas.GridLines = true;
            listOrdenesPreparadas.Location = new Point(30, 57);
            listOrdenesPreparadas.MultiSelect = false;
            listOrdenesPreparadas.Name = "listOrdenesPreparadas";
            listOrdenesPreparadas.Size = new Size(783, 231);
            listOrdenesPreparadas.TabIndex = 8;
            listOrdenesPreparadas.UseCompatibleStateImageBehavior = false;
            listOrdenesPreparadas.View = View.Details;
            listOrdenesPreparadas.MouseClick += listOrdenesPreparadas_MouseClick;
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
            // PrioridadColum
            // 
            PrioridadColum.Text = "Prioridad";
            PrioridadColum.TextAlign = HorizontalAlignment.Center;
            PrioridadColum.Width = 130;
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
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 9;
            label1.Text = "Listado de ordenes de preparación";
            label1.Click += label1_Click;
            // 
            // SiguienteBtn
            // 
            SiguienteBtn.Location = new Point(30, 294);
            SiguienteBtn.Name = "SiguienteBtn";
            SiguienteBtn.Size = new Size(103, 26);
            SiguienteBtn.TabIndex = 10;
            SiguienteBtn.Text = "Siguiente";
            SiguienteBtn.UseVisualStyleBackColor = true;
            SiguienteBtn.Click += SiguienteBtn_Click;
            // 
            // ConfirmarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 375);
            Controls.Add(SiguienteBtn);
            Controls.Add(label1);
            Controls.Add(listOrdenesPreparadas);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Name = "ConfirmarOrdenDeEntregaForm";
            Text = "Confirmar Orden de Entrega";
            Load += ConfirmarOrdenDeEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private ListView listOrdenesPreparadas;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader EstadoColum;
        private Label label1;
        private Button SiguienteBtn;
        private ColumnHeader PrioridadColum;
    }
}