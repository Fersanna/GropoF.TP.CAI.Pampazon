namespace GrupoF.TP.CAI.Pampazon
{
    partial class GenerarOrdenDeEntregaForm
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
            listOrdenesEntrega = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(529, 274);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(90, 27);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(625, 274);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(90, 27);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listOrdenesEntrega
            // 
            listOrdenesEntrega.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listOrdenesEntrega.GridLines = true;
            listOrdenesEntrega.Location = new Point(36, 56);
            listOrdenesEntrega.Name = "listOrdenesEntrega";
            listOrdenesEntrega.Size = new Size(679, 202);
            listOrdenesEntrega.TabIndex = 7;
            listOrdenesEntrega.UseCompatibleStateImageBehavior = false;
            listOrdenesEntrega.View = View.Details;
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
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 8;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // GenerarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 332);
            Controls.Add(label1);
            Controls.Add(listOrdenesEntrega);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Name = "GenerarOrdenDeEntregaForm";
            Text = "Generar Orden de Entrega";
            Load += GenerarOrdenDeEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private ListView listOrdenesEntrega;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader EstadoColum;
        private Label label1;
    }
}