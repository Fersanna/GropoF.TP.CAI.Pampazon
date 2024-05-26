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
            CodigoHeader = new ColumnHeader();
            DescripcionHeader = new ColumnHeader();
            RazonSocialTexBox = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            ImprimirBtn = new Button();
            DomicilioTextBox = new TextBox();
            label5 = new Label();
            RemitoTextBox = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            label6 = new Label();
            CancelarBtn = new Button();
            CantidadHeader = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // FechaRemitoTimePicker
            // 
            FechaRemitoTimePicker.Enabled = false;
            FechaRemitoTimePicker.Format = DateTimePickerFormat.Short;
            FechaRemitoTimePicker.Location = new Point(523, 64);
            FechaRemitoTimePicker.Margin = new Padding(3, 4, 3, 4);
            FechaRemitoTimePicker.Name = "FechaRemitoTimePicker";
            FechaRemitoTimePicker.Size = new Size(116, 27);
            FechaRemitoTimePicker.TabIndex = 0;
            // 
            // Cuit_Box
            // 
            Cuit_Box.Enabled = false;
            Cuit_Box.Location = new Point(106, 107);
            Cuit_Box.Mask = "00-00000000-0";
            Cuit_Box.Name = "Cuit_Box";
            Cuit_Box.ResetOnPrompt = false;
            Cuit_Box.ResetOnSpace = false;
            Cuit_Box.Size = new Size(107, 27);
            Cuit_Box.TabIndex = 13;
            Cuit_Box.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 107);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 14;
            label1.Text = "CUIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 68);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 15;
            label2.Text = "Fecha";
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { CodigoHeader, DescripcionHeader, CantidadHeader });
            ProductosList.Enabled = false;
            ProductosList.FullRowSelect = true;
            ProductosList.GridLines = true;
            ProductosList.Location = new Point(33, 231);
            ProductosList.Margin = new Padding(3, 4, 3, 4);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(659, 219);
            ProductosList.TabIndex = 16;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            // 
            // CodigoHeader
            // 
            CodigoHeader.Text = "Codigo Producto";
            CodigoHeader.Width = 160;
            // 
            // DescripcionHeader
            // 
            DescripcionHeader.Text = "Descripción";
            DescripcionHeader.Width = 400;
            // 
            // RazonSocialTexBox
            // 
            RazonSocialTexBox.Enabled = false;
            RazonSocialTexBox.Location = new Point(106, 29);
            RazonSocialTexBox.Margin = new Padding(3, 4, 3, 4);
            RazonSocialTexBox.Name = "RazonSocialTexBox";
            RazonSocialTexBox.Size = new Size(228, 27);
            RazonSocialTexBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 33);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 18;
            label3.Text = "Razón Social";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(347, 12);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(43, 27);
            textBox2.TabIndex = 40;
            textBox2.Text = "R";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // ImprimirBtn
            // 
            ImprimirBtn.Location = new Point(472, 517);
            ImprimirBtn.Margin = new Padding(3, 4, 3, 4);
            ImprimirBtn.Name = "ImprimirBtn";
            ImprimirBtn.Size = new Size(107, 33);
            ImprimirBtn.TabIndex = 41;
            ImprimirBtn.Text = "Imprimir";
            ImprimirBtn.UseVisualStyleBackColor = true;
            ImprimirBtn.Click += ImprimirBtn_Click;
            // 
            // DomicilioTextBox
            // 
            DomicilioTextBox.Enabled = false;
            DomicilioTextBox.Location = new Point(106, 68);
            DomicilioTextBox.Margin = new Padding(3, 4, 3, 4);
            DomicilioTextBox.Name = "DomicilioTextBox";
            DomicilioTextBox.Size = new Size(228, 27);
            DomicilioTextBox.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 68);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 44;
            label5.Text = "Domicilio";
            // 
            // RemitoTextBox
            // 
            RemitoTextBox.Enabled = false;
            RemitoTextBox.Location = new Point(523, 25);
            RemitoTextBox.Margin = new Padding(3, 4, 3, 4);
            RemitoTextBox.Name = "RemitoTextBox";
            RemitoTextBox.Size = new Size(116, 27);
            RemitoTextBox.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 29);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
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
            groupBox1.Location = new Point(33, 51);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(659, 153);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(576, 468);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 27);
            textBox5.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 472);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 47;
            label6.Text = "Total";
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(585, 517);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(107, 33);
            CancelarBtn.TabIndex = 49;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // CantidadHeader
            // 
            CantidadHeader.Text = "Cantidad";
            CantidadHeader.Width = 150;
            // 
            // RemitosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 567);
            Controls.Add(CancelarBtn);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(groupBox1);
            Controls.Add(ImprimirBtn);
            Controls.Add(textBox2);
            Controls.Add(ProductosList);
            Margin = new Padding(3, 4, 3, 4);
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
        private ColumnHeader CodigoHeader;
        private ColumnHeader DescripcionHeader;
        private Button ImprimirBtn;
        private TextBox DomicilioTextBox;
        private Label label5;
        private TextBox RemitoTextBox;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label6;
        private Button CancelarBtn;
        private ColumnHeader CantidadHeader;
    }
}