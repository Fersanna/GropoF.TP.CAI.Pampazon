namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    partial class BuscarPosicionForm
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
            BuscarBtn = new Button();
            listView1 = new ListView();
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(668, 378);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(88, 23);
            BuscarBtn.TabIndex = 3;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(51, 55);
            listView1.Name = "listView1";
            listView1.Size = new Size(705, 289);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(574, 378);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(88, 23);
            CancelarBtn.TabIndex = 5;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // BuscarPosicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(listView1);
            Controls.Add(BuscarBtn);
            Name = "BuscarPosicionForm";
            Text = "Buscar Posición";
            ResumeLayout(false);
        }

        #endregion

        private Button BuscarBtn;
        private ListView listView1;
        private Button CancelarBtn;
    }
}