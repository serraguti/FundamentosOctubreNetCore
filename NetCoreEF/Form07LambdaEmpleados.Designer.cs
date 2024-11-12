namespace NetCoreEF
{
    partial class Form07LambdaEmpleados
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
            cmbDepartamentos = new ComboBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtPersonas = new TextBox();
            label4 = new Label();
            txtMaximoSalario = new TextBox();
            label5 = new Label();
            txtMinimoSalario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(24, 54);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(286, 38);
            cmbDepartamentos.TabIndex = 1;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 21);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(375, 55);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(424, 394);
            lstEmpleados.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 188);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 4;
            label3.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(34, 217);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(195, 35);
            txtPersonas.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 271);
            label4.Name = "label4";
            label4.Size = new Size(154, 30);
            label4.TabIndex = 6;
            label4.Text = "Máximo salario";
            // 
            // txtMaximoSalario
            // 
            txtMaximoSalario.Location = new Point(37, 303);
            txtMaximoSalario.Name = "txtMaximoSalario";
            txtMaximoSalario.Size = new Size(192, 35);
            txtMaximoSalario.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 355);
            label5.Name = "label5";
            label5.Size = new Size(150, 30);
            label5.TabIndex = 8;
            label5.Text = "Mínimo salario";
            // 
            // txtMinimoSalario
            // 
            txtMinimoSalario.Location = new Point(39, 385);
            txtMinimoSalario.Name = "txtMinimoSalario";
            txtMinimoSalario.Size = new Size(190, 35);
            txtMinimoSalario.TabIndex = 9;
            // 
            // Form07LambdaEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 489);
            Controls.Add(txtMinimoSalario);
            Controls.Add(label5);
            Controls.Add(txtMaximoSalario);
            Controls.Add(label4);
            Controls.Add(txtPersonas);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form07LambdaEmpleados";
            Text = "Form07LambdaEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtPersonas;
        private Label label4;
        private TextBox txtMaximoSalario;
        private Label label5;
        private TextBox txtMinimoSalario;
    }
}