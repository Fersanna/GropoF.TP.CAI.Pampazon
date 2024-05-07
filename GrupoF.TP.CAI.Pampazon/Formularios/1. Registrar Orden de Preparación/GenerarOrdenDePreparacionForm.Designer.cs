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
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            GenerarBtn = new Button();
            AgregarBtn = new Button();
            OdenEnPrepList = new ListView();
            CodigoProductoCol = new ColumnHeader();
            DescripcionCol = new ColumnHeader();
            PosicionCol = new ColumnHeader();
            CantidadCol = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
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
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(455, 339);
            AgregarBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(101, 31);
            AgregarBtn.TabIndex = 2;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // OdenEnPrepList
            // 
            OdenEnPrepList.Columns.AddRange(new ColumnHeader[] { CodigoProductoCol, DescripcionCol, PosicionCol, CantidadCol });
            OdenEnPrepList.FullRowSelect = true;
            OdenEnPrepList.GridLines = true;
            OdenEnPrepList.Location = new Point(67, 398);
            OdenEnPrepList.Margin = new Padding(3, 4, 3, 4);
            OdenEnPrepList.Name = "OdenEnPrepList";
            OdenEnPrepList.Size = new Size(489, 146);
            OdenEnPrepList.TabIndex = 3;
            OdenEnPrepList.UseCompatibleStateImageBehavior = false;
            OdenEnPrepList.View = View.Details;
            // 
            // CodigoProductoCol
            // 
            CodigoProductoCol.Text = "Codigo Producto";
            CodigoProductoCol.Width = 120;
            // 
            // DescripcionCol
            // 
            DescripcionCol.Text = "Descripcion";
            DescripcionCol.TextAlign = HorizontalAlignment.Center;
            DescripcionCol.Width = 120;
            // 
            // PosicionCol
            // 
            PosicionCol.Text = "Posicion";
            PosicionCol.TextAlign = HorizontalAlignment.Center;
            PosicionCol.Width = 120;
            // 
            // CantidadCol
            // 
            CantidadCol.Text = "Cantidad";
            CantidadCol.TextAlign = HorizontalAlignment.Center;
            CantidadCol.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 58);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 4;
            label1.Text = "Productos del Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 350);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 5;
            label2.Text = "Agregados a la Orden";
            // 
            // GenerarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 615);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OdenEnPrepList);
            Controls.Add(AgregarBtn);
            Controls.Add(GenerarBtn);
            Controls.Add(PorductosList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarOrdenDePreparacionForm";
            Text = "Generar Orden de Preparación";
            Load += GenerarOrdenDePreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView PorductosList;
        private Button GenerarBtn;
        private Button AgregarBtn;
        private ListView OdenEnPrepList;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
        private Label label1;
        private Label label2;
        private ColumnHeader CodigoProductoCol;
        private ColumnHeader DescripcionCol;
        private ColumnHeader PosicionCol;
        private ColumnHeader CantidadCol;
    }
}