namespace GrupoF.TP.CAI.Pampazon
{
    partial class ConfirmarOrdenDeEntregaForm
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
            EliminarBtn = new Button();
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(70, 77);
            listView1.Name = "listView1";
            listView1.Size = new Size(646, 227);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(613, 331);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(103, 26);
            ConfirmarBtn.TabIndex = 1;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(504, 331);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(103, 26);
            EliminarBtn.TabIndex = 2;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(395, 331);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(103, 26);
            CancelarBtn.TabIndex = 3;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // ConfirmarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(listView1);
            Name = "ConfirmarOrdenDeEntregaForm";
            Text = "Confirmar Orden de Entrega";
            Load += ConfirmarOrdenDeEntregaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button ConfirmarBtn;
        private Button EliminarBtn;
        private Button CancelarBtn;
    }
}