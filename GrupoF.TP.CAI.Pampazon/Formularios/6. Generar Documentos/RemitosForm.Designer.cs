namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    partial class RemitosForm
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
            dateTimePicker1 = new DateTimePicker();
            Cuit_Box = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            ProductosList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            ImprimirBtn = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            label6 = new Label();
            CancelarBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(376, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // Cuit_Box
            // 
            Cuit_Box.Enabled = false;
            Cuit_Box.Location = new Point(93, 80);
            Cuit_Box.Margin = new Padding(3, 2, 3, 2);
            Cuit_Box.Mask = "00-00000000-0";
            Cuit_Box.Name = "Cuit_Box";
            Cuit_Box.ResetOnPrompt = false;
            Cuit_Box.ResetOnSpace = false;
            Cuit_Box.Size = new Size(94, 23);
            Cuit_Box.TabIndex = 13;
            Cuit_Box.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 80);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 14;
            label1.Text = "CUIT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 54);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 15;
            label2.Text = "Fecha";
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            ProductosList.Enabled = false;
            ProductosList.FullRowSelect = true;
            ProductosList.GridLines = true;
            ProductosList.Location = new Point(29, 173);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(577, 165);
            ProductosList.TabIndex = 16;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cantidad";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripción";
            columnHeader2.Width = 400;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(93, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 25);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 18;
            label3.Text = "Razón Social";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(304, 9);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(38, 23);
            textBox2.TabIndex = 40;
            textBox2.Text = "R";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // ImprimirBtn
            // 
            ImprimirBtn.Location = new Point(413, 388);
            ImprimirBtn.Name = "ImprimirBtn";
            ImprimirBtn.Size = new Size(94, 25);
            ImprimirBtn.TabIndex = 41;
            ImprimirBtn.Text = "Imprimir";
            ImprimirBtn.UseVisualStyleBackColor = true;
            ImprimirBtn.Click += ImprimirBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(93, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 51);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 44;
            label5.Text = "Domicilio";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(376, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(102, 23);
            textBox4.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 25);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 46;
            label4.Text = "Remito";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Cuit_Box);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(29, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 115);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(86, 355);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 358);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 47;
            label6.Text = "Total";
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(512, 388);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(94, 25);
            CancelarBtn.TabIndex = 49;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // RemitosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 425);
            Controls.Add(CancelarBtn);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(groupBox1);
            Controls.Add(ImprimirBtn);
            Controls.Add(textBox2);
            Controls.Add(ProductosList);
            Name = "RemitosForm";
            Text = "Remitos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private MaskedTextBox Cuit_Box;
        private Label label1;
        private Label label2;
        private ListView ProductosList;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button ImprimirBtn;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label6;
        private Button CancelarBtn;
    }
}