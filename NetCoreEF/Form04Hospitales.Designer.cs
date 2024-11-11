namespace NetCoreEF
{
    partial class Form04Hospitales
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
            label1 = new Label();
            btnCargarHospitales = new Button();
            lsvHospitales = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 88);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // btnCargarHospitales
            // 
            btnCargarHospitales.Location = new Point(33, 20);
            btnCargarHospitales.Name = "btnCargarHospitales";
            btnCargarHospitales.Size = new Size(266, 52);
            btnCargarHospitales.TabIndex = 2;
            btnCargarHospitales.Text = "Cargar hospitales";
            btnCargarHospitales.UseVisualStyleBackColor = true;
            btnCargarHospitales.Click += btnCargarHospitales_Click;
            // 
            // lsvHospitales
            // 
            lsvHospitales.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvHospitales.FullRowSelect = true;
            lsvHospitales.Location = new Point(33, 121);
            lsvHospitales.Name = "lsvHospitales";
            lsvHospitales.Size = new Size(665, 395);
            lsvHospitales.TabIndex = 3;
            lsvHospitales.UseCompatibleStateImageBehavior = false;
            lsvHospitales.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Camas";
            columnHeader5.Width = 100;
            // 
            // Form04Hospitales
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 548);
            Controls.Add(lsvHospitales);
            Controls.Add(btnCargarHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04Hospitales";
            Text = "Form04Hospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCargarHospitales;
        private ListView lsvHospitales;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}