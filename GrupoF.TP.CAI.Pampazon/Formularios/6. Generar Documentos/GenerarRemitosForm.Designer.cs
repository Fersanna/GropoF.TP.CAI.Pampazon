namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    partial class GenerarRemitosForm
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
            label1 = new Label();
            listOrdenesDeEntrega = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            RemitoColum = new ColumnHeader();
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(576, 421);
            ConfirmarBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(120, 40);
            ConfirmarBtn.TabIndex = 12;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 64);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 11;
            label1.Text = "Detalle de ordenes";
            // 
            // listOrdenesDeEntrega
            // 
            listOrdenesDeEntrega.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, RemitoColum });
            listOrdenesDeEntrega.FullRowSelect = true;
            listOrdenesDeEntrega.GridLines = true;
            listOrdenesDeEntrega.Location = new Point(59, 88);
            listOrdenesDeEntrega.Margin = new Padding(3, 4, 3, 4);
            listOrdenesDeEntrega.Name = "listOrdenesDeEntrega";
            listOrdenesDeEntrega.Size = new Size(762, 311);
            listOrdenesDeEntrega.TabIndex = 10;
            listOrdenesDeEntrega.UseCompatibleStateImageBehavior = false;
            listOrdenesDeEntrega.View = View.Details;
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
            // RemitoColum
            // 
            RemitoColum.Text = "Remito";
            RemitoColum.TextAlign = HorizontalAlignment.Center;
            RemitoColum.Width = 130;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(702, 421);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(120, 40);
            CancelarBtn.TabIndex = 9;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // GenerarRemitosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 490);
            Controls.Add(ConfirmarBtn);
            Controls.Add(label1);
            Controls.Add(listOrdenesDeEntrega);
            Controls.Add(CancelarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarRemitosForm";
            Text = "Generar Remitos";
            Load += GenerarRemitosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmarBtn;
        private Label label1;
        private ListView listOrdenesDeEntrega;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader RemitoColum;
        private Button CancelarBtn;
    }
}