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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            // button2
            // 
            button2.Location = new Point(42, 92);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(270, 52);
            button2.TabIndex = 1;
            button2.Text = "Orden de Seleccion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OrdenSeleccionClick;
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
            // button4
            // 
            button4.Location = new Point(42, 230);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(270, 52);
            button4.TabIndex = 3;
            button4.Text = "Generar Documentos";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(42, 299);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(270, 52);
            button5.TabIndex = 4;
            button5.Text = "Confirmar Orden";
            button5.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 369);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(OrdeDePreparacionBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button OrdeDePreparacionBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
