namespace NetCoreEF
{
    partial class Form02BuscadorEmpleados
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
            txtSalario = new TextBox();
            btnBuscarSalarios = new Button();
            label2 = new Label();
            txtOficio = new TextBox();
            btnBuscarOficios = new Button();
            label3 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 0;
            label1.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(29, 55);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(269, 35);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarSalarios
            // 
            btnBuscarSalarios.Location = new Point(31, 107);
            btnBuscarSalarios.Name = "btnBuscarSalarios";
            btnBuscarSalarios.Size = new Size(267, 57);
            btnBuscarSalarios.TabIndex = 2;
            btnBuscarSalarios.Text = "Buscar salarios";
            btnBuscarSalarios.UseVisualStyleBackColor = true;
            btnBuscarSalarios.Click += btnBuscarSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 25);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 3;
            label2.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(376, 54);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(270, 35);
            txtOficio.TabIndex = 4;
            // 
            // btnBuscarOficios
            // 
            btnBuscarOficios.Location = new Point(377, 109);
            btnBuscarOficios.Name = "btnBuscarOficios";
            btnBuscarOficios.Size = new Size(269, 55);
            btnBuscarOficios.TabIndex = 5;
            btnBuscarOficios.Text = "Buscar oficios";
            btnBuscarOficios.UseVisualStyleBackColor = true;
            btnBuscarOficios.Click += btnBuscarOficios_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 190);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 6;
            label3.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(38, 221);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(558, 274);
            lstEmpleados.TabIndex = 7;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 518);
            Controls.Add(lstEmpleados);
            Controls.Add(label3);
            Controls.Add(btnBuscarOficios);
            Controls.Add(txtOficio);
            Controls.Add(label2);
            Controls.Add(btnBuscarSalarios);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarSalarios;
        private Label label2;
        private TextBox txtOficio;
        private Button btnBuscarOficios;
        private Label label3;
        private ListBox lstEmpleados;
    }
}