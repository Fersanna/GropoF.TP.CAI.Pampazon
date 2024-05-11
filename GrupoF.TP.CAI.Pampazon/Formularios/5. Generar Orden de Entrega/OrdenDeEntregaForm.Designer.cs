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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "E-000001", "01", "13/05/24", "Express Cargo" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "E-000002", "02", "13/05/24", "Logística Global" }, -1);
            EliminarBtn = new Button();
            CancelarBtn = new Button();
            listView2 = new ListView();
            NumeroColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            SuspendLayout();
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(506, 345);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(105, 30);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(395, 345);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(105, 30);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { NumeroColum, ClienteColum, FechaColum, TranspColum });
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView2.Location = new Point(75, 87);
            listView2.Name = "listView2";
            listView2.Size = new Size(536, 234);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
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
            // OrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(listView2);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Name = "OrdenDeEntregaForm";
            Text = "Orden de Entrega";
            ResumeLayout(false);
        }

        #endregion
        private Button EliminarBtn;
        private Button CancelarBtn;
        private ListView listView2;
        private ColumnHeader NumeroColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
    }
}