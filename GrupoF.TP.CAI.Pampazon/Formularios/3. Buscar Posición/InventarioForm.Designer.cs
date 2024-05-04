namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    partial class InventarioForm
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
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(49, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(681, 287);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(624, 357);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(102, 29);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(516, 357);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(102, 29);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(listView1);
            Name = "InventarioForm";
            Text = "Inventario";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button ConfirmarBtn;
        private Button CancelarBtn;
    }
}