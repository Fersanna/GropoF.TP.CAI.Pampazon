namespace GrupoF.TP.CAI.Pampazon
{
    partial class BuscarClienteForm
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
            CancelarBtn = new Button();
            ClientesList = new ListView();
            CodigoHeader = new ColumnHeader();
            RazonSocialHeader = new ColumnHeader();
            CUITHeader = new ColumnHeader();
            DomicilioHeader = new ColumnHeader();
            SeleccionarBtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(620, 407);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(113, 31);
            CancelarBtn.TabIndex = 0;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // ClientesList
            // 
            ClientesList.Columns.AddRange(new ColumnHeader[] { CodigoHeader, RazonSocialHeader, CUITHeader, DomicilioHeader });
            ClientesList.FullRowSelect = true;
            ClientesList.Location = new Point(40, 172);
            ClientesList.Margin = new Padding(3, 4, 3, 4);
            ClientesList.Name = "ClientesList";
            ClientesList.Size = new Size(689, 227);
            ClientesList.TabIndex = 1;
            ClientesList.UseCompatibleStateImageBehavior = false;
            ClientesList.View = View.Details;
            // 
            // CodigoHeader
            // 
            CodigoHeader.Text = "Codigo Cliente";
            CodigoHeader.Width = 150;
            // 
            // RazonSocialHeader
            // 
            RazonSocialHeader.Text = "Razon Social";
            RazonSocialHeader.TextAlign = HorizontalAlignment.Center;
            RazonSocialHeader.Width = 150;
            // 
            // CUITHeader
            // 
            CUITHeader.Text = "CUIT";
            CUITHeader.TextAlign = HorizontalAlignment.Center;
            CUITHeader.Width = 150;
            // 
            // DomicilioHeader
            // 
            DomicilioHeader.Text = "Domicilio";
            DomicilioHeader.TextAlign = HorizontalAlignment.Center;
            DomicilioHeader.Width = 150;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(501, 407);
            SeleccionarBtn.Margin = new Padding(3, 4, 3, 4);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(113, 31);
            SeleccionarBtn.TabIndex = 3;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 148);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 6;
            label1.Text = "Listado Clientes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 56);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(0, 91);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(689, 27);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(40, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(689, 125);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 11;
            label2.Text = "Cuit";
            // 
            // BuscarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 451);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(SeleccionarBtn);
            Controls.Add(ClientesList);
            Controls.Add(CancelarBtn);
            Name = "BuscarClienteForm";
            Text = "Buscar Cliente";
            Load += BuscarClienteForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelarBtn;
        private ListView ClientesList;
        private Button SeleccionarBtn;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ColumnHeader CodigoHeader;
        private ColumnHeader RazonSocialHeader;
        private ColumnHeader CUITHeader;
        private ColumnHeader DomicilioHeader;
        private GroupBox groupBox1;
        private Label label2;
    }
}
