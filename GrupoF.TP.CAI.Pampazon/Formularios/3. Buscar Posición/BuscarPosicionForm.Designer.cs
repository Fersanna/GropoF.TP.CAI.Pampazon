namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    partial class BuscarPosicionForm
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
            ConsultarBtn = new Button();
            CancelarBtn = new Button();
            listOrdenesDeSeleccion = new ListView();
            NumeroColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // ConsultarBtn
            // 
            ConsultarBtn.Location = new Point(374, 306);
            ConsultarBtn.Name = "ConsultarBtn";
            ConsultarBtn.Size = new Size(88, 23);
            ConsultarBtn.TabIndex = 3;
            ConsultarBtn.Text = "Consultar";
            ConsultarBtn.UseVisualStyleBackColor = true;
            ConsultarBtn.Click += ConsultarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(468, 306);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(88, 23);
            CancelarBtn.TabIndex = 5;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listOrdenesDeSeleccion
            // 
            listOrdenesDeSeleccion.Columns.AddRange(new ColumnHeader[] { NumeroColum, FechaColum });
            listOrdenesDeSeleccion.GridLines = true;
            listOrdenesDeSeleccion.Location = new Point(66, 44);
            listOrdenesDeSeleccion.Name = "listOrdenesDeSeleccion";
            listOrdenesDeSeleccion.Size = new Size(490, 256);
            listOrdenesDeSeleccion.TabIndex = 6;
            listOrdenesDeSeleccion.UseCompatibleStateImageBehavior = false;
            listOrdenesDeSeleccion.View = View.Details;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "ID";
            NumeroColum.Width = 350;
            // 
            // FechaColum
            // 
            FechaColum.Text = "Prioridad";
            FechaColum.TextAlign = HorizontalAlignment.Center;
            FechaColum.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 26);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 7;
            label1.Text = "Listado de ordenes de selección";
            // 
            // BuscarPosicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 384);
            Controls.Add(label1);
            Controls.Add(listOrdenesDeSeleccion);
            Controls.Add(CancelarBtn);
            Controls.Add(ConsultarBtn);
            Name = "BuscarPosicionForm";
            Text = "Buscar Posición";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConsultarBtn;
        private Button CancelarBtn;
        private ListView listOrdenesDeSeleccion;
        private ColumnHeader NumeroColum;
        private ColumnHeader FechaColum;
        private Label label1;
    }
}