﻿namespace AdoNet
{
    partial class Form02BuscadorSalarios
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
            btnBuscarEmpleadosSalario = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 13);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(51, 41);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(262, 35);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarEmpleadosSalario
            // 
            btnBuscarEmpleadosSalario.Location = new Point(51, 85);
            btnBuscarEmpleadosSalario.Name = "btnBuscarEmpleadosSalario";
            btnBuscarEmpleadosSalario.Size = new Size(262, 55);
            btnBuscarEmpleadosSalario.TabIndex = 2;
            btnBuscarEmpleadosSalario.Text = "Buscar empleados";
            btnBuscarEmpleadosSalario.UseVisualStyleBackColor = true;
            btnBuscarEmpleadosSalario.Click += btnBuscarEmpleadosSalario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 158);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 30;
            lstEmpleados.Location = new Point(57, 191);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(256, 244);
            lstEmpleados.TabIndex = 4;
            // 
            // Form02BuscadorSalarios
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 459);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscarEmpleadosSalario);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02BuscadorSalarios";
            Text = "Form02BuscadorSalarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarEmpleadosSalario;
        private Label label2;
        private ListBox lstEmpleados;
    }
}