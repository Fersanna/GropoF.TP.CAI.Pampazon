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
            EliminarBtn = new Button();
            listView1 = new ListView();
            FechaColum = new ColumnHeader();
            TranspColum = new ColumnHeader();
            ClienteColum = new ColumnHeader();
            NumeroColum = new ColumnHeader();
            EstadoColum = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(597, 377);
            EliminarBtn.Margin = new Padding(3, 4, 3, 4);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(114, 36);
            EliminarBtn.TabIndex = 1;
            EliminarBtn.Text = "Confirmar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { FechaColum, TranspColum, ClienteColum, NumeroColum, EstadoColum });
            listView1.GridLines = true;
            listView1.Location = new Point(35, 37);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(797, 309);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // FechaColum
            // 
            FechaColum.Text = "Fecha";
            FechaColum.Width = 150;
            // 
            // TranspColum
            // 
            TranspColum.Text = "Transportista";
            TranspColum.TextAlign = HorizontalAlignment.Center;
            TranspColum.Width = 150;
            // 
            // ClienteColum
            // 
            ClienteColum.Text = "Cliente";
            ClienteColum.TextAlign = HorizontalAlignment.Center;
            ClienteColum.Width = 150;
            // 
            // NumeroColum
            // 
            NumeroColum.Text = "Numero de Orden";
            NumeroColum.TextAlign = HorizontalAlignment.Center;
            NumeroColum.Width = 150;
            // 
            // EstadoColum
            // 
            EstadoColum.Text = "Estado";
            EstadoColum.TextAlign = HorizontalAlignment.Center;
            EstadoColum.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(717, 377);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 36);
            button1.TabIndex = 4;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(EliminarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenDeSeleccionForm";
            Text = "Orden de Seleccion";
            ResumeLayout(false);
        }

        #endregion
        private Button EliminarBtn;
        private ListView listView1;
        private ColumnHeader FechaColum;
        private ColumnHeader TranspColum;
        private ColumnHeader ClienteColum;
        private ColumnHeader NumeroColum;
        private ColumnHeader EstadoColum;
        private Button button1;
    }
}