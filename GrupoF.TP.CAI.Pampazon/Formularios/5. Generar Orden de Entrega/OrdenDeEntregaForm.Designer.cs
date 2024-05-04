namespace GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega
{
    partial class OrdenDeEntregaForm
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
            EliminarBtn = new Button();
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(66, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(638, 268);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(599, 345);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(105, 30);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(488, 345);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(105, 30);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // OrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(listView1);
            Name = "OrdenDeEntregaForm";
            Text = "Orden de Entrega";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button EliminarBtn;
        private Button CancelarBtn;
    }
}