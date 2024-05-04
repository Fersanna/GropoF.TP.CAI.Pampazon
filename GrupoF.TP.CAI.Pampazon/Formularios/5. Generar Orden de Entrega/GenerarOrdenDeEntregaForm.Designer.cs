namespace GrupoF.TP.CAI.Pampazon
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
            GenerarBtn = new Button();
            CancelarBtn = new Button();
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
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(625, 347);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(90, 27);
            GenerarBtn.TabIndex = 1;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(529, 347);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(90, 27);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // GenerarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(GenerarBtn);
            Controls.Add(listView1);
            Name = "GenerarOrdenDeEntregaForm";
            Text = "Generar Orden de Entrega";
            Load += GenerarOrdenDeEntregaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button GenerarBtn;
        private Button CancelarBtn;
    }
}