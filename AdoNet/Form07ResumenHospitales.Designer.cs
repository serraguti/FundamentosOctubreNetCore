namespace AdoNet
{
    partial class Form07ResumenHospitales
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
            txtDoctores = new TextBox();
            label3 = new Label();
            txtMaximoSalario = new TextBox();
            label4 = new Label();
            txtMinimoSalario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 30;
            lstHospitales.Location = new Point(33, 52);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(277, 304);
            lstHospitales.TabIndex = 1;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 22);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Doctores";
            // 
            // txtDoctores
            // 
            txtDoctores.Location = new Point(400, 53);
            txtDoctores.Name = "txtDoctores";
            txtDoctores.Size = new Size(211, 35);
            txtDoctores.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 104);
            label3.Name = "label3";
            label3.Size = new Size(154, 30);
            label3.TabIndex = 4;
            label3.Text = "Máximo salario";
            // 
            // txtMaximoSalario
            // 
            txtMaximoSalario.Location = new Point(402, 136);
            txtMaximoSalario.Name = "txtMaximoSalario";
            txtMaximoSalario.Size = new Size(209, 35);
            txtMaximoSalario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 192);
            label4.Name = "label4";
            label4.Size = new Size(150, 30);
            label4.TabIndex = 6;
            label4.Text = "Mínimo salario";
            // 
            // txtMinimoSalario
            // 
            txtMinimoSalario.Location = new Point(405, 225);
            txtMinimoSalario.Name = "txtMinimoSalario";
            txtMinimoSalario.Size = new Size(206, 35);
            txtMinimoSalario.TabIndex = 7;
            // 
            // Form07ResumenHospitales
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 410);
            Controls.Add(txtMinimoSalario);
            Controls.Add(label4);
            Controls.Add(txtMaximoSalario);
            Controls.Add(label3);
            Controls.Add(txtDoctores);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form07ResumenHospitales";
            Text = "Form07ResumenHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Label label2;
        private TextBox txtDoctores;
        private Label label3;
        private TextBox txtMaximoSalario;
        private Label label4;
        private TextBox txtMinimoSalario;
    }
}