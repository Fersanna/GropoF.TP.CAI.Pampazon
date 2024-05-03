namespace GrupoF.TP.CAI.Pampazon
{
    partial class OrdenDePrepForm
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
            CancelarOrdenPrepBtn = new Button();
            listView1 = new ListView();
            SeleccionarBtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // CancelarOrdenPrepBtn
            // 
            CancelarOrdenPrepBtn.Location = new Point(568, 272);
            CancelarOrdenPrepBtn.Name = "CancelarOrdenPrepBtn";
            CancelarOrdenPrepBtn.Size = new Size(75, 23);
            CancelarOrdenPrepBtn.TabIndex = 0;
            CancelarOrdenPrepBtn.Text = "&Cancelar";
            CancelarOrdenPrepBtn.UseVisualStyleBackColor = true;
            CancelarOrdenPrepBtn.Click += CancelarOrdenPrepBtn_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(40, 77);
            listView1.Name = "listView1";
            listView1.Size = new Size(603, 171);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(487, 272);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(75, 23);
            SeleccionarBtn.TabIndex = 3;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Clientes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(280, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrdenDePrepForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(SeleccionarBtn);
            Controls.Add(listView1);
            Controls.Add(CancelarOrdenPrepBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrdenDePrepForm";
            Text = "Orden De Preparacion";
            Load += OrdenDePrepForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelarOrdenPrepBtn;
        private ListView listView1;
        private Button SeleccionarBtn;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}
