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
            OrdenSeleccionBtn = new Button();
            button3 = new Button();
            GenerarDocBtn = new Button();
            ConfirmarOrdeBtn = new Button();
            SuspendLayout();
            // 
            // OrdeDePreparacionBtn
            // 
            OrdeDePreparacionBtn.Location = new Point(42, 23);
            OrdeDePreparacionBtn.Margin = new Padding(3, 2, 3, 2);
            OrdeDePreparacionBtn.Name = "OrdeDePreparacionBtn";
            OrdeDePreparacionBtn.Size = new Size(270, 52);
            OrdeDePreparacionBtn.TabIndex = 0;
            OrdeDePreparacionBtn.Text = "Orden de Preparacion";
            OrdeDePreparacionBtn.UseVisualStyleBackColor = true;
            OrdeDePreparacionBtn.Click += OrdenPreparacionClick;
            // 
            // OrdenSeleccionBtn
            // 
            OrdenSeleccionBtn.Location = new Point(42, 92);
            OrdenSeleccionBtn.Margin = new Padding(3, 2, 3, 2);
            OrdenSeleccionBtn.Name = "OrdenSeleccionBtn";
            OrdenSeleccionBtn.Size = new Size(270, 52);
            OrdenSeleccionBtn.TabIndex = 1;
            OrdenSeleccionBtn.Text = "Orden de Seleccion";
            OrdenSeleccionBtn.UseVisualStyleBackColor = true;
            OrdenSeleccionBtn.Click += OrdenSeleccionClick;
            // 
            // button3
            // 
            button3.Location = new Point(42, 161);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(270, 52);
            button3.TabIndex = 2;
            button3.Text = "Orden de Entrega";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OrdenEntrega_Click;
            // 
            // GenerarDocBtn
            // 
            GenerarDocBtn.Location = new Point(42, 230);
            GenerarDocBtn.Margin = new Padding(3, 2, 3, 2);
            GenerarDocBtn.Name = "GenerarDocBtn";
            GenerarDocBtn.Size = new Size(270, 52);
            GenerarDocBtn.TabIndex = 3;
            GenerarDocBtn.Text = "Generar Documentos";
            GenerarDocBtn.UseVisualStyleBackColor = true;
            GenerarDocBtn.Click += GenerarDocBtn_Click;
            // 
            // ConfirmarOrdeBtn
            // 
            ConfirmarOrdeBtn.Location = new Point(42, 299);
            ConfirmarOrdeBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdeBtn.Name = "ConfirmarOrdeBtn";
            ConfirmarOrdeBtn.Size = new Size(270, 52);
            ConfirmarOrdeBtn.TabIndex = 4;
            ConfirmarOrdeBtn.Text = "Confirmar Orden";
            ConfirmarOrdeBtn.UseVisualStyleBackColor = true;
            ConfirmarOrdeBtn.Click += ConfirmarOrdeBtn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 369);
            Controls.Add(ConfirmarOrdeBtn);
            Controls.Add(GenerarDocBtn);
            Controls.Add(button3);
            Controls.Add(OrdenSeleccionBtn);
            Controls.Add(OrdeDePreparacionBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button OrdeDePreparacionBtn;
        private Button OrdenSeleccionBtn;
        private Button button3;
        private Button GenerarDocBtn;
        private Button ConfirmarOrdeBtn;
    }
}
