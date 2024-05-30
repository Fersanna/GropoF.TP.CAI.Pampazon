namespace GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega
{
    partial class OrdenDespachadaForm
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
            listOrdenesDespachadas = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            label1 = new Label();
            AceptarBtn = new Button();
            SuspendLayout();
            // 
            // listOrdenesDespachadas
            // 
            listOrdenesDespachadas.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum, EstadoColum });
            listOrdenesDespachadas.GridLines = true;
            listOrdenesDespachadas.Location = new Point(39, 85);
            listOrdenesDespachadas.Margin = new Padding(3, 4, 3, 4);
            listOrdenesDespachadas.Name = "listOrdenesDespachadas";
            listOrdenesDespachadas.Size = new Size(764, 268);
            listOrdenesDespachadas.TabIndex = 9;
            listOrdenesDespachadas.UseCompatibleStateImageBehavior = false;
            listOrdenesDespachadas.View = View.Details;
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
            label1.Location = new Point(39, 61);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 10;
            label1.Text = "Listado de ordenes de preparación";
            // 
            // AceptarBtn
            // 
            AceptarBtn.Location = new Point(686, 387);
            AceptarBtn.Margin = new Padding(3, 4, 3, 4);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(118, 35);
            AceptarBtn.TabIndex = 11;
            AceptarBtn.Text = "Aceptar";
            AceptarBtn.UseVisualStyleBackColor = true;
            AceptarBtn.Click += AceptarBtn_Click;
            // 
            // OrdenDespachadaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 468);
            Controls.Add(AceptarBtn);
            Controls.Add(label1);
            Controls.Add(listOrdenesDespachadas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenDespachadaForm";
            Text = "OrdenDespachadaForm";
            Load += OrdenDespachadaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listOrdenesDespachadas;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader EstadoColum;
        private Label label1;
        private Button AceptarBtn;
    }
}