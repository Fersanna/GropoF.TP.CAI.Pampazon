﻿namespace GrupoF.TP.CAI.Pampazon
{
    partial class GenerarOrdenDeEntregaForm
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
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(67, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(648, 261);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(625, 347);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 1;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "GenerarOrdenDeEntregaForm";
            Text = "Generar Orden de Entrega";
            Load += OrdenDeEntregForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
    }
}