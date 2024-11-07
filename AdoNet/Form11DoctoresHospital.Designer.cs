namespace AdoNet
{
    partial class Form11DoctoresHospital
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
            lsvHospitales = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            lsvDoctores = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label3 = new Label();
            txtIncrementoSalarial = new TextBox();
            btnIncrementar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lsvHospitales
            // 
            lsvHospitales.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvHospitales.FullRowSelect = true;
            lsvHospitales.Location = new Point(30, 52);
            lsvHospitales.Name = "lsvHospitales";
            lsvHospitales.Size = new Size(788, 281);
            lsvHospitales.TabIndex = 1;
            lsvHospitales.UseCompatibleStateImageBehavior = false;
            lsvHospitales.View = View.Details;
            lsvHospitales.SelectedIndexChanged += lsvHospitales_SelectedIndexChanged;
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
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Camas";
            columnHeader5.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 345);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Doctores";
            // 
            // lsvDoctores
            // 
            lsvDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lsvDoctores.FullRowSelect = true;
            lsvDoctores.Location = new Point(33, 376);
            lsvDoctores.Name = "lsvDoctores";
            lsvDoctores.Size = new Size(785, 220);
            lsvDoctores.TabIndex = 3;
            lsvDoctores.UseCompatibleStateImageBehavior = false;
            lsvDoctores.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ID";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Apellido";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Especialidad";
            columnHeader8.Width = 180;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Salario";
            columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Hospital";
            columnHeader10.Width = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 18);
            label3.Name = "label3";
            label3.Size = new Size(189, 30);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial";
            // 
            // txtIncrementoSalarial
            // 
            txtIncrementoSalarial.Location = new Point(848, 50);
            txtIncrementoSalarial.Name = "txtIncrementoSalarial";
            txtIncrementoSalarial.Size = new Size(208, 35);
            txtIncrementoSalarial.TabIndex = 5;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(850, 94);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(206, 90);
            btnIncrementar.TabIndex = 6;
            btnIncrementar.Text = "Incrementar salarios";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // Form11DoctoresHospital
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 621);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncrementoSalarial);
            Controls.Add(label3);
            Controls.Add(lsvDoctores);
            Controls.Add(label2);
            Controls.Add(lsvHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form11DoctoresHospital";
            Text = "Form11DoctoresHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvHospitales;
        private Label label2;
        private ListView lsvDoctores;
        private Label label3;
        private TextBox txtIncrementoSalarial;
        private Button btnIncrementar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}