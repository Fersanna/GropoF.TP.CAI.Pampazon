namespace GrupoF.TP.CAI.Pampazon.Formularios
{
    partial class GenerarOrdenDePreparacionForm
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
            PorductosList = new ListView();
            GenerarBtn = new Button();
            button2 = new Button();
            listView2 = new ListView();
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            SuspendLayout();
            // 
            // PorductosList
            // 
            PorductosList.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header });
            PorductosList.FullRowSelect = true;
            PorductosList.GridLines = true;
            PorductosList.Location = new Point(68, 91);
            PorductosList.Margin = new Padding(3, 4, 3, 4);
            PorductosList.Name = "PorductosList";
            PorductosList.Size = new Size(488, 224);
            PorductosList.TabIndex = 0;
            PorductosList.UseCompatibleStateImageBehavior = false;
            PorductosList.View = View.Details;
            PorductosList.SelectedIndexChanged += PorductosList_SelectedIndexChanged;
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(455, 556);
            GenerarBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(101, 31);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(455, 339);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 31);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(67, 435);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(489, 109);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // IdProducto_Header
            // 
            IdProducto_Header.Text = "Codigo Producto";
            IdProducto_Header.Width = 120;
            // 
            // Descripcion_Header
            // 
            Descripcion_Header.Text = "Descripcion";
            Descripcion_Header.TextAlign = HorizontalAlignment.Center;
            Descripcion_Header.Width = 120;
            // 
            // Posicion_Header
            // 
            Posicion_Header.Text = "Posicion";
            Posicion_Header.TextAlign = HorizontalAlignment.Center;
            Posicion_Header.Width = 120;
            // 
            // Cantidad_Header
            // 
            Cantidad_Header.Text = "Cantidad";
            Cantidad_Header.TextAlign = HorizontalAlignment.Center;
            Cantidad_Header.Width = 120;
            // 
            // GenerarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 615);
            Controls.Add(listView2);
            Controls.Add(button2);
            Controls.Add(GenerarBtn);
            Controls.Add(PorductosList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarOrdenDePreparacionForm";
            Text = "Generar Orden de Preparación";
            Load += GenerarOrdenDePreparacionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView PorductosList;
        private Button GenerarBtn;
        private Button button2;
        private ListView listView2;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
    }
}