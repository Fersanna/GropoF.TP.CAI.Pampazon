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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "S-000001", "13/05/25" }, -1);
            BuscarBtn = new Button();
            CancelarBtn = new Button();
            listView1 = new ListView();
            NumeroColum = new ColumnHeader();
            FechaColum = new ColumnHeader();
            SuspendLayout();
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(296, 353);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(88, 23);
            BuscarBtn.TabIndex = 3;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(200, 353);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(88, 23);
            CancelarBtn.TabIndex = 5;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroColum, FechaColum });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(66, 70);
            listView1.Name = "listView1";
            listView1.Size = new Size(318, 256);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // BuscarPosicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(listView1);
            Controls.Add(CancelarBtn);
            Controls.Add(BuscarBtn);
            Name = "BuscarPosicionForm";
            Text = "Buscar Posición";
            ResumeLayout(false);
        }

        #endregion

        private Button BuscarBtn;
        private Button CancelarBtn;
        private ListView listView1;
        private ColumnHeader NumeroColum;
        private ColumnHeader FechaColum;
    }
}