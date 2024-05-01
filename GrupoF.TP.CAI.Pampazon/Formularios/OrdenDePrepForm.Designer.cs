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
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // CancelarOrdenPrepBtn
            // 
            CancelarOrdenPrepBtn.Location = new Point(649, 363);
            CancelarOrdenPrepBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarOrdenPrepBtn.Name = "CancelarOrdenPrepBtn";
            CancelarOrdenPrepBtn.Size = new Size(86, 31);
            CancelarOrdenPrepBtn.TabIndex = 0;
            CancelarOrdenPrepBtn.Text = "&Cancelar";
            CancelarOrdenPrepBtn.UseVisualStyleBackColor = true;
            CancelarOrdenPrepBtn.Click += CancelarOrdenPrepBtn_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(46, 103);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(689, 227);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(557, 363);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 2;
            button2.Text = "&Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(464, 363);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 3;
            button3.Text = "&Aceptar";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(46, 40);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 28);
            comboBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(47, 363);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 6;
            label1.Text = "Clientes";
            // 
            // OrdenDePrepForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(CancelarOrdenPrepBtn);
            Name = "OrdenDePrepForm";
            Text = "Orden De Preparacion";
            Load += OrdenDePrepForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelarOrdenPrepBtn;
        private ListView listView1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}
