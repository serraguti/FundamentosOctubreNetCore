namespace NetCoreEFFinal
{
    partial class Form02HospitalesDoctores
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
            lstHospitales = new ListBox();
            label2 = new Label();
            lsvDoctores = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label3 = new Label();
            txtIncrementoSalarial = new TextBox();
            btnIncrementarSalarios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(206, 30);
            label1.TabIndex = 0;
            label1.Text = "Números de hospital";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 30;
            lstHospitales.Location = new Point(25, 49);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(273, 334);
            lstHospitales.TabIndex = 1;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 15);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Doctores";
            // 
            // lsvDoctores
            // 
            lsvDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvDoctores.FullRowSelect = true;
            lsvDoctores.Location = new Point(329, 48);
            lsvDoctores.Name = "lsvDoctores";
            lsvDoctores.Size = new Size(650, 335);
            lsvDoctores.TabIndex = 3;
            lsvDoctores.UseCompatibleStateImageBehavior = false;
            lsvDoctores.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Apellido";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Especialidad";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Salario";
            columnHeader3.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 396);
            label3.Name = "label3";
            label3.Size = new Size(189, 30);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial";
            // 
            // txtIncrementoSalarial
            // 
            txtIncrementoSalarial.Location = new Point(29, 425);
            txtIncrementoSalarial.Name = "txtIncrementoSalarial";
            txtIncrementoSalarial.Size = new Size(269, 35);
            txtIncrementoSalarial.TabIndex = 5;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(329, 417);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(316, 43);
            btnIncrementarSalarios.TabIndex = 6;
            btnIncrementarSalarios.Text = "Incrementar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // Form02HospitalesDoctores
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 522);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(txtIncrementoSalarial);
            Controls.Add(label3);
            Controls.Add(lsvDoctores);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02HospitalesDoctores";
            Text = "Form02HospitalesDoctores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Label label2;
        private ListView lsvDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label3;
        private TextBox txtIncrementoSalarial;
        private Button btnIncrementarSalarios;
    }
}