﻿namespace NetCoreEF
{
    partial class Form06VistaEmpleados
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
            lsvVistaEmpleados = new ListView();
            btnCargarVistaEmpleados = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 0;
            label1.Text = "Vista empleados";
            // 
            // lsvVistaEmpleados
            // 
            lsvVistaEmpleados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lsvVistaEmpleados.FullRowSelect = true;
            lsvVistaEmpleados.Location = new Point(40, 47);
            lsvVistaEmpleados.Name = "lsvVistaEmpleados";
            lsvVistaEmpleados.Size = new Size(888, 444);
            lsvVistaEmpleados.TabIndex = 1;
            lsvVistaEmpleados.UseCompatibleStateImageBehavior = false;
            lsvVistaEmpleados.View = View.Details;
            // 
            // btnCargarVistaEmpleados
            // 
            btnCargarVistaEmpleados.Location = new Point(39, 507);
            btnCargarVistaEmpleados.Name = "btnCargarVistaEmpleados";
            btnCargarVistaEmpleados.Size = new Size(271, 50);
            btnCargarVistaEmpleados.TabIndex = 2;
            btnCargarVistaEmpleados.Text = "Cargar Vista Empleados";
            btnCargarVistaEmpleados.UseVisualStyleBackColor = true;
            btnCargarVistaEmpleados.Click += btnCargarVistaEmpleados_Click;
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
            columnHeader3.Text = "Oficio";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Salario";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Departamento";
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Localidad";
            columnHeader6.Width = 160;
            // 
            // Form06VistaEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 581);
            Controls.Add(btnCargarVistaEmpleados);
            Controls.Add(lsvVistaEmpleados);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06VistaEmpleados";
            Text = "Form06VistaEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvVistaEmpleados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnCargarVistaEmpleados;
    }
}