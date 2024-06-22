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
            RegistrarOrdenDePreparacionBtn = new Button();
            GenerarOrdenDeSeleccionBtn = new Button();
            GenerarOrdenDeEntregaBtn = new Button();
            GenerarRemitosBtn = new Button();
            ConfirmarOrdenDeEntregaBtn = new Button();
            ConfirmarOrdenDeSeleccionBtn = new Button();
            ConfirmarOrdenSeleccionadaBtn = new Button();
            SuspendLayout();
            // 
            // RegistrarOrdenDePreparacionBtn
            // 
            RegistrarOrdenDePreparacionBtn.Location = new Point(42, 23);
            RegistrarOrdenDePreparacionBtn.Margin = new Padding(3, 2, 3, 2);
            RegistrarOrdenDePreparacionBtn.Name = "RegistrarOrdenDePreparacionBtn";
            RegistrarOrdenDePreparacionBtn.Size = new Size(270, 52);
            RegistrarOrdenDePreparacionBtn.TabIndex = 0;
            RegistrarOrdenDePreparacionBtn.Text = "Registrar Orden de Preparación";
            RegistrarOrdenDePreparacionBtn.UseVisualStyleBackColor = true;
            RegistrarOrdenDePreparacionBtn.Click += RegistrarOrdenDePreparacion_Click;
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
            GenerarOrdenDeSeleccionBtn.Click += GenerarOrdenDeSeleccionBtn_Click;
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
            GenerarOrdenDeEntregaBtn.Click += GenerarOrdenDeEntregaBtn_Click;
            // 
            // GenerarRemitosBtn
            // 
            GenerarRemitosBtn.Location = new Point(42, 350);
            GenerarRemitosBtn.Margin = new Padding(3, 2, 3, 2);
            GenerarRemitosBtn.Name = "GenerarRemitosBtn";
            GenerarRemitosBtn.Size = new Size(270, 52);
            GenerarRemitosBtn.TabIndex = 3;
            GenerarRemitosBtn.Text = "Generar Remitos";
            GenerarRemitosBtn.UseVisualStyleBackColor = true;
            GenerarRemitosBtn.Click += GenerarRemitosBtn_Click;
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
            ConfirmarOrdenDeEntregaBtn.Click += ConfirmarOrdenDeEntregaBtn_Click;
            // 
            // ConfirmarOrdenDeSeleccionBtn
            // 
            ConfirmarOrdenDeSeleccionBtn.Location = new Point(42, 155);
            ConfirmarOrdenDeSeleccionBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenDeSeleccionBtn.Name = "ConfirmarOrdenDeSeleccionBtn";
            ConfirmarOrdenDeSeleccionBtn.Size = new Size(270, 52);
            ConfirmarOrdenDeSeleccionBtn.TabIndex = 5;
            ConfirmarOrdenDeSeleccionBtn.Text = "Confirmar Orden de Selección";
            ConfirmarOrdenDeSeleccionBtn.UseVisualStyleBackColor = true;
            ConfirmarOrdenDeSeleccionBtn.Click += ConfirmarOrdenDeSeleccionBtn_Click;
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
            ConfirmarOrdenSeleccionadaBtn.Click += ConfirmarOrdenSeleccionadaBtn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 495);
            Controls.Add(ConfirmarOrdenSeleccionadaBtn);
            Controls.Add(ConfirmarOrdenDeSeleccionBtn);
            Controls.Add(ConfirmarOrdenDeEntregaBtn);
            Controls.Add(GenerarRemitosBtn);
            Controls.Add(GenerarOrdenDeEntregaBtn);
            Controls.Add(GenerarOrdenDeSeleccionBtn);
            Controls.Add(RegistrarOrdenDePreparacionBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button RegistrarOrdenDePreparacionBtn;
        private Button GenerarOrdenDeSeleccionBtn;
        private Button GenerarOrdenDeEntregaBtn;
        private Button GenerarRemitosBtn;
        private Button ConfirmarOrdenDeEntregaBtn;
        private Button ConfirmarOrdenDeSeleccionBtn;
        private Button ConfirmarOrdenSeleccionadaBtn;
    }
}
