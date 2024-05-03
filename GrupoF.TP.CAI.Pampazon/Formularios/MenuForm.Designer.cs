namespace GrupoF.TP.CAI.Pampazon
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrdeDePreparacionBtn = new Button();
            GenerarOrdenDeSeleccionBtn = new Button();
            GenerarOrdenDeEntregaBtn = new Button();
            GenerarDocumentosBtn = new Button();
            ConfirmarOrdenDeEntregaBtn = new Button();
            BuscarPosiciónBtn = new Button();
            ConfirmarOrdenSeleccionadaBtn = new Button();
            SuspendLayout();
            // 
            // OrdeDePreparacionBtn
            // 
            OrdeDePreparacionBtn.Location = new Point(42, 23);
            OrdeDePreparacionBtn.Margin = new Padding(3, 2, 3, 2);
            OrdeDePreparacionBtn.Name = "OrdeDePreparacionBtn";
            OrdeDePreparacionBtn.Size = new Size(270, 52);
            OrdeDePreparacionBtn.TabIndex = 0;
            OrdeDePreparacionBtn.Text = "Registrar Orden de Preparación";
            OrdeDePreparacionBtn.UseVisualStyleBackColor = true;
            OrdeDePreparacionBtn.Click += OrdenPreparacionClick;
            // 
            // GenerarOrdenDeSeleccionBtn
            // 
            GenerarOrdenDeSeleccionBtn.Location = new Point(42, 88);
            GenerarOrdenDeSeleccionBtn.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeSeleccionBtn.Name = "GenerarOrdenDeSeleccionBtn";
            GenerarOrdenDeSeleccionBtn.Size = new Size(270, 52);
            GenerarOrdenDeSeleccionBtn.TabIndex = 1;
            GenerarOrdenDeSeleccionBtn.Text = "Generar Orden de Selección";
            GenerarOrdenDeSeleccionBtn.UseVisualStyleBackColor = true;
            GenerarOrdenDeSeleccionBtn.Click += OrdenSeleccionClick;
            // 
            // GenerarOrdenDeEntregaBtn
            // 
            GenerarOrdenDeEntregaBtn.Location = new Point(42, 285);
            GenerarOrdenDeEntregaBtn.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeEntregaBtn.Name = "GenerarOrdenDeEntregaBtn";
            GenerarOrdenDeEntregaBtn.Size = new Size(270, 52);
            GenerarOrdenDeEntregaBtn.TabIndex = 2;
            GenerarOrdenDeEntregaBtn.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregaBtn.UseVisualStyleBackColor = true;
            GenerarOrdenDeEntregaBtn.Click += OrdenEntrega_Click;
            // 
            // GenerarDocumentosBtn
            // 
            GenerarDocumentosBtn.Location = new Point(42, 350);
            GenerarDocumentosBtn.Margin = new Padding(3, 2, 3, 2);
            GenerarDocumentosBtn.Name = "GenerarDocumentosBtn";
            GenerarDocumentosBtn.Size = new Size(270, 52);
            GenerarDocumentosBtn.TabIndex = 3;
            GenerarDocumentosBtn.Text = "Generar Documentos";
            GenerarDocumentosBtn.UseVisualStyleBackColor = true;
            GenerarDocumentosBtn.Click += GenerarDocBtn_Click;
            // 
            // ConfirmarOrdenDeEntregaBtn
            // 
            ConfirmarOrdenDeEntregaBtn.Location = new Point(42, 415);
            ConfirmarOrdenDeEntregaBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenDeEntregaBtn.Name = "ConfirmarOrdenDeEntregaBtn";
            ConfirmarOrdenDeEntregaBtn.Size = new Size(270, 52);
            ConfirmarOrdenDeEntregaBtn.TabIndex = 4;
            ConfirmarOrdenDeEntregaBtn.Text = "Confirmar Orden de Entrega";
            ConfirmarOrdenDeEntregaBtn.UseVisualStyleBackColor = true;
            ConfirmarOrdenDeEntregaBtn.Click += ConfirmarOrdeBtn_Click;
            // 
            // BuscarPosiciónBtn
            // 
            BuscarPosiciónBtn.Location = new Point(42, 155);
            BuscarPosiciónBtn.Margin = new Padding(3, 2, 3, 2);
            BuscarPosiciónBtn.Name = "BuscarPosiciónBtn";
            BuscarPosiciónBtn.Size = new Size(270, 52);
            BuscarPosiciónBtn.TabIndex = 5;
            BuscarPosiciónBtn.Text = "Buscar Posición";
            BuscarPosiciónBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmarOrdenSeleccionadaBtn
            // 
            ConfirmarOrdenSeleccionadaBtn.Location = new Point(42, 220);
            ConfirmarOrdenSeleccionadaBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenSeleccionadaBtn.Name = "ConfirmarOrdenSeleccionadaBtn";
            ConfirmarOrdenSeleccionadaBtn.Size = new Size(270, 52);
            ConfirmarOrdenSeleccionadaBtn.TabIndex = 6;
            ConfirmarOrdenSeleccionadaBtn.Text = "Confirmar Orden Seleccionada";
            ConfirmarOrdenSeleccionadaBtn.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 495);
            Controls.Add(ConfirmarOrdenSeleccionadaBtn);
            Controls.Add(BuscarPosiciónBtn);
            Controls.Add(ConfirmarOrdenDeEntregaBtn);
            Controls.Add(GenerarDocumentosBtn);
            Controls.Add(GenerarOrdenDeEntregaBtn);
            Controls.Add(GenerarOrdenDeSeleccionBtn);
            Controls.Add(OrdeDePreparacionBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button OrdeDePreparacionBtn;
        private Button GenerarOrdenDeSeleccionBtn;
        private Button GenerarOrdenDeEntregaBtn;
        private Button GenerarDocumentosBtn;
        private Button ConfirmarOrdenDeEntregaBtn;
        private Button BuscarPosiciónBtn;
        private Button ConfirmarOrdenSeleccionadaBtn;
    }
}
