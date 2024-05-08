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
            ProductosList = new ListView();
            IdProducto_Header = new ColumnHeader();
            Descripcion_Header = new ColumnHeader();
            Posicion_Header = new ColumnHeader();
            Cantidad_Header = new ColumnHeader();
            GenerarBtn = new Button();
            AgregarBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            EditarOrden_GridView = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Posicion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)EditarOrden_GridView).BeginInit();
            SuspendLayout();
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { IdProducto_Header, Descripcion_Header, Posicion_Header, Cantidad_Header });
            ProductosList.FullRowSelect = true;
            ProductosList.GridLines = true;
            ProductosList.Location = new Point(68, 91);
            ProductosList.Margin = new Padding(3, 4, 3, 4);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(522, 224);
            ProductosList.TabIndex = 0;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            ProductosList.SelectedIndexChanged += PorductosList_SelectedIndexChanged;
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
            GenerarBtn.Location = new Point(489, 585);
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
            AgregarBtn.Location = new Point(489, 339);
            AgregarBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(101, 31);
            AgregarBtn.TabIndex = 2;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
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
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Editar Orden";
            // 
            // EditarOrden_GridView
            // 
            EditarOrden_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditarOrden_GridView.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Descripcion, Posicion, Cantidad });
            EditarOrden_GridView.Location = new Point(68, 383);
            EditarOrden_GridView.Name = "EditarOrden_GridView";
            EditarOrden_GridView.RowHeadersWidth = 51;
            EditarOrden_GridView.RowTemplate.Height = 29;
            EditarOrden_GridView.Size = new Size(522, 188);
            EditarOrden_GridView.TabIndex = 6;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Codigo Producto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 125;
            // 
            // Posicion
            // 
            Posicion.HeaderText = "Posicion";
            Posicion.MinimumWidth = 6;
            Posicion.Name = "Posicion";
            Posicion.ReadOnly = true;
            Posicion.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // GenerarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 629);
            Controls.Add(EditarOrden_GridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AgregarBtn);
            Controls.Add(GenerarBtn);
            Controls.Add(ProductosList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarOrdenDePreparacionForm";
            Text = "Generar Orden de Preparación";
            Load += GenerarOrdenDePreparacionForm_Load;
            ((System.ComponentModel.ISupportInitialize)EditarOrden_GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ProductosList;
        private Button GenerarBtn;
        private Button AgregarBtn;
        private ColumnHeader IdProducto_Header;
        private ColumnHeader Descripcion_Header;
        private ColumnHeader Posicion_Header;
        private ColumnHeader Cantidad_Header;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Posicion;
        private DataGridViewTextBoxColumn Cantidad;
        public DataGridView EditarOrden_GridView;
    }
}