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
            listView1 = new ListView();
            GenerarBtn = new Button();
            button2 = new Button();
            listView2 = new ListView();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(59, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(640, 169);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(611, 415);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(88, 23);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(611, 205);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(59, 326);
            listView2.Name = "listView2";
            listView2.Size = new Size(640, 83);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // GenerarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView2);
            Controls.Add(button2);
            Controls.Add(GenerarBtn);
            Controls.Add(listView1);
            Name = "GenerarOrdenDePreparacionForm";
            Text = "Generar Orden de Preparación";
            Load += GenerarOrdenDePreparacionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button GenerarBtn;
        private Button button2;
        private ListView listView2;
    }
}