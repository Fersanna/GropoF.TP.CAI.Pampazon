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
            FechaRemitoTimePicker = new DateTimePicker();
            Cuit_Box = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            ProductosList = new ListView();
            IdHeader = new ColumnHeader();
            DescripcionHeader = new ColumnHeader();
            CantidadHeader = new ColumnHeader();
            RazonSocialTexBox = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            ImprimirBtn = new Button();
            DomicilioTextBox = new TextBox();
            label5 = new Label();
            RemitoTextBox = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            CancelarBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // FechaRemitoTimePicker
            // 
            FechaRemitoTimePicker.Enabled = false;
            FechaRemitoTimePicker.Format = DateTimePickerFormat.Short;
            FechaRemitoTimePicker.Location = new Point(458, 51);
            FechaRemitoTimePicker.Name = "FechaRemitoTimePicker";
            FechaRemitoTimePicker.Size = new Size(102, 23);
            FechaRemitoTimePicker.TabIndex = 0;
            // 
            // Cuit_Box
            // 
            Cuit_Box.Enabled = false;
            Cuit_Box.Location = new Point(93, 54);
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
            label1.Location = new Point(28, 57);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 14;
            label1.Text = "CUIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 54);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 15;
            label2.Text = "Fecha";
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { IdHeader, DescripcionHeader, CantidadHeader });
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
            // IdHeader
            // 
            IdHeader.Text = "ID";
            IdHeader.Width = 100;
            // 
            // DescripcionHeader
            // 
            DescripcionHeader.Text = "Descripción";
            DescripcionHeader.Width = 370;
            // 
            // CantidadHeader
            // 
            CantidadHeader.Text = "Cantidad";
            CantidadHeader.TextAlign = HorizontalAlignment.Center;
            CantidadHeader.Width = 100;
            // 
            // RazonSocialTexBox
            // 
            RazonSocialTexBox.Enabled = false;
            RazonSocialTexBox.Location = new Point(93, 22);
            RazonSocialTexBox.Name = "RazonSocialTexBox";
            RazonSocialTexBox.Size = new Size(200, 23);
            RazonSocialTexBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 18;
            label3.Text = "Razón Social";
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
            ImprimirBtn.Text = "Generar";
            ImprimirBtn.UseVisualStyleBackColor = true;
            ImprimirBtn.Click += ImprimirBtn_Click;
            // 
            // DomicilioTextBox
            // 
            DomicilioTextBox.Enabled = false;
            DomicilioTextBox.Location = new Point(93, 83);
            DomicilioTextBox.Name = "DomicilioTextBox";
            DomicilioTextBox.Size = new Size(307, 23);
            DomicilioTextBox.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 86);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 44;
            label5.Text = "Domicilio";
            // 
            // RemitoTextBox
            // 
            RemitoTextBox.Enabled = false;
            RemitoTextBox.Location = new Point(458, 19);
            RemitoTextBox.Name = "RemitoTextBox";
            RemitoTextBox.Size = new Size(102, 23);
            RemitoTextBox.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 22);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 46;
            label4.Text = "Remito";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FechaRemitoTimePicker);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Cuit_Box);
            groupBox1.Controls.Add(RemitoTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DomicilioTextBox);
            groupBox1.Controls.Add(RazonSocialTexBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(29, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 115);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
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
            Controls.Add(groupBox1);
            Controls.Add(ImprimirBtn);
            Controls.Add(textBox2);
            Controls.Add(ProductosList);
            Name = "RemitosForm";
            Text = "Remitos";
            Load += RemitosForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker FechaRemitoTimePicker;
        private MaskedTextBox Cuit_Box;
        private Label label1;
        private Label label2;
        private ListView ProductosList;
        private TextBox RazonSocialTexBox;
        private Label label3;
        private TextBox textBox2;
        private ColumnHeader DescripcionHeader;
        private Button ImprimirBtn;
        private TextBox DomicilioTextBox;
        private Label label5;
        private TextBox RemitoTextBox;
        private Label label4;
        private GroupBox groupBox1;
        private Button CancelarBtn;
        private ColumnHeader IdHeader;
        private ColumnHeader CantidadHeader;
    }
}