namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    partial class OrdenDeSeleccionForm
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
            listView1.Location = new Point(39, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(689, 288);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(628, 357);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(100, 27);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(522, 357);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(100, 27);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(listView1);
            Name = "OrdenDeSeleccionForm";
            Text = "Orden de Seleccion";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button EliminarBtn;
        private Button CancelarBtn;
    }
}