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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "18", "Sillas" }, -1);
            dateTimePicker1 = new DateTimePicker();
            Cuit_Box = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            ProductosList = new ListView();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(378, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // Cuit_Box
            // 
            Cuit_Box.Location = new Point(108, 147);
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
            label1.Location = new Point(29, 147);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 14;
            label1.Text = "CUIT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 51);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 15;
            label2.Text = "Fecha:";
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            ProductosList.FullRowSelect = true;
            ProductosList.GridLines = true;
            ProductosList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            ProductosList.Location = new Point(29, 187);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(540, 190);
            ProductosList.TabIndex = 16;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 92);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 18;
            label3.Text = "Razón Social";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 12);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(38, 23);
            textBox2.TabIndex = 40;
            textBox2.Text = "X";
            textBox2.TextAlign = HorizontalAlignment.Center;
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
            // button1
            // 
            button1.Location = new Point(475, 394);
            button1.Name = "button1";
            button1.Size = new Size(94, 25);
            button1.TabIndex = 41;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 118);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 44;
            label5.Text = "Domicilio";
            // 
            // RemitosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 448);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(ProductosList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cuit_Box);
            Controls.Add(dateTimePicker1);
            Name = "RemitosForm";
            Text = "Remitos";
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
        private Button button1;
        private TextBox textBox3;
        private Label label5;
    }
}