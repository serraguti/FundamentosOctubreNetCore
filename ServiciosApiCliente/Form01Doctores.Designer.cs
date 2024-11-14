namespace ServiciosApiCliente
{
    partial class Form01Doctores
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
            lsvDoctores = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            txtIdDoctor = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtEspecialidad = new TextBox();
            label5 = new Label();
            txtSalario = new TextBox();
            label6 = new Label();
            txtHospital = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 0;
            label1.Text = "Doctores";
            // 
            // lsvDoctores
            // 
            lsvDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvDoctores.FullRowSelect = true;
            lsvDoctores.Location = new Point(28, 55);
            lsvDoctores.Name = "lsvDoctores";
            lsvDoctores.Size = new Size(803, 366);
            lsvDoctores.TabIndex = 1;
            lsvDoctores.UseCompatibleStateImageBehavior = false;
            lsvDoctores.View = View.Details;
            lsvDoctores.SelectedIndexChanged += lsvDoctores_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Apellido";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Especialidad";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Salario";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Hospital";
            columnHeader5.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(878, 21);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 2;
            label2.Text = "Id doctor";
            // 
            // txtIdDoctor
            // 
            txtIdDoctor.Location = new Point(883, 57);
            txtIdDoctor.Name = "txtIdDoctor";
            txtIdDoctor.Size = new Size(100, 35);
            txtIdDoctor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(884, 107);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(886, 140);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 35);
            txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(886, 191);
            label4.Name = "label4";
            label4.Size = new Size(127, 30);
            label4.TabIndex = 6;
            label4.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(890, 222);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(228, 35);
            txtEspecialidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(890, 275);
            label5.Name = "label5";
            label5.Size = new Size(75, 30);
            label5.TabIndex = 8;
            label5.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(894, 307);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(184, 35);
            txtSalario.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(892, 355);
            label6.Name = "label6";
            label6.Size = new Size(89, 30);
            label6.TabIndex = 10;
            label6.Text = "Hospital";
            // 
            // txtHospital
            // 
            txtHospital.Location = new Point(897, 385);
            txtHospital.Name = "txtHospital";
            txtHospital.Size = new Size(112, 35);
            txtHospital.TabIndex = 11;
            // 
            // Form01Doctores
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 475);
            Controls.Add(txtHospital);
            Controls.Add(label6);
            Controls.Add(txtSalario);
            Controls.Add(label5);
            Controls.Add(txtEspecialidad);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtIdDoctor);
            Controls.Add(label2);
            Controls.Add(lsvDoctores);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01Doctores";
            Text = "Form01Doctores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private TextBox txtIdDoctor;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtEspecialidad;
        private Label label5;
        private TextBox txtSalario;
        private Label label6;
        private TextBox txtHospital;
    }
}