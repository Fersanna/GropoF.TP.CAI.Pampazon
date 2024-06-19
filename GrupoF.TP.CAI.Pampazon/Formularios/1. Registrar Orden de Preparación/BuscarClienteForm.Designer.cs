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
            BuscarBtn = new Button();
            groupBox1 = new GroupBox();
            Cuit_Box = new MaskedTextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(654, 371);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(99, 23);
            CancelarBtn.TabIndex = 0;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // ClientesList
            // 
            ClientesList.Columns.AddRange(new ColumnHeader[] { CodigoHeader, RazonSocialHeader, CUITHeader, DomicilioHeader });
            ClientesList.FullRowSelect = true;
            ClientesList.GridLines = true;
            ClientesList.Location = new Point(35, 129);
            ClientesList.MultiSelect = false;
            ClientesList.Name = "ClientesList";
            ClientesList.Size = new Size(718, 237);
            ClientesList.TabIndex = 1;
            ClientesList.UseCompatibleStateImageBehavior = false;
            ClientesList.View = View.Details;
            ClientesList.SelectedIndexChanged += ClientesList_SelectedIndexChanged;
            // 
            // CodigoHeader
            // 
            CodigoHeader.Text = "Código Cliente";
            CodigoHeader.Width = 100;
            // 
            // RazonSocialHeader
            // 
            RazonSocialHeader.Text = "Razón Social";
            RazonSocialHeader.TextAlign = HorizontalAlignment.Center;
            RazonSocialHeader.Width = 180;
            // 
            // CUITHeader
            // 
            CUITHeader.Text = "CUIT";
            CUITHeader.TextAlign = HorizontalAlignment.Center;
            CUITHeader.Width = 120;
            // 
            // DomicilioHeader
            // 
            DomicilioHeader.Text = "Domicilio";
            DomicilioHeader.TextAlign = HorizontalAlignment.Center;
            DomicilioHeader.Width = 290;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(549, 372);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(99, 23);
            SeleccionarBtn.TabIndex = 3;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 111);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 6;
            label1.Text = "Listado de clientes";
            label1.Click += label1_Click;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(6, 63);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(706, 23);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += Buscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cuit_Box);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BuscarBtn);
            groupBox1.Location = new Point(35, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(718, 96);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Cuit_Box
            // 
            Cuit_Box.Location = new Point(6, 35);
            Cuit_Box.Margin = new Padding(3, 2, 3, 2);
            Cuit_Box.Mask = "00-00000000-0";
            Cuit_Box.Name = "Cuit_Box";
            Cuit_Box.ResetOnPrompt = false;
            Cuit_Box.ResetOnSpace = false;
            Cuit_Box.Size = new Size(94, 23);
            Cuit_Box.TabIndex = 12;
            Cuit_Box.TabStop = false;
            Cuit_Box.Validating += Cuit_Box_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 11;
            label2.Text = "CUIT";
            // 
            // BuscarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 418);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(SeleccionarBtn);
            Controls.Add(ClientesList);
            Controls.Add(CancelarBtn);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button BuscarBtn;
        private ColumnHeader CodigoHeader;
        private ColumnHeader RazonSocialHeader;
        private ColumnHeader CUITHeader;
        private ColumnHeader DomicilioHeader;
        private GroupBox groupBox1;
        private Label label2;
        private MaskedTextBox Cuit_Box;
    }
}
