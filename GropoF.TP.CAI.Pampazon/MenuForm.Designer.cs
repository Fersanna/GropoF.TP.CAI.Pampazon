﻿namespace GropoF.TP.CAI.Pampazon
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 31);
            button1.Name = "button1";
            button1.Size = new Size(309, 69);
            button1.TabIndex = 0;
            button1.Text = "Orden de Preparacion";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(48, 129);
            button2.Name = "button2";
            button2.Size = new Size(309, 69);
            button2.TabIndex = 1;
            button2.Text = "Orden de Seleccion";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(48, 230);
            button3.Name = "button3";
            button3.Size = new Size(309, 69);
            button3.TabIndex = 2;
            button3.Text = "Orden de Entrega";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(48, 316);
            button4.Name = "button4";
            button4.Size = new Size(309, 69);
            button4.TabIndex = 3;
            button4.Text = "Generar Documentos";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(48, 400);
            button5.Name = "button5";
            button5.Size = new Size(309, 69);
            button5.TabIndex = 4;
            button5.Text = "Confirmar Orden";
            button5.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 492);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuForm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
