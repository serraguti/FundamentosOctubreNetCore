namespace NetCoreEF
{
    partial class Form09IncrementarSalarioEmpleados
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
            lstOficios = new ListBox();
            label2 = new Label();
            lsvEmpleados = new ListView();
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
            label1.Location = new Point(27, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 30;
            lstOficios.Location = new Point(31, 47);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(280, 274);
            lstOficios.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 15);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lsvEmpleados
            // 
            lsvEmpleados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvEmpleados.FullRowSelect = true;
            lsvEmpleados.Location = new Point(350, 51);
            lsvEmpleados.Name = "lsvEmpleados";
            lsvEmpleados.Size = new Size(560, 270);
            lsvEmpleados.TabIndex = 3;
            lsvEmpleados.UseCompatibleStateImageBehavior = false;
            lsvEmpleados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "APELLIDO";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "OFICIO";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SALARIO";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 337);
            label3.Name = "label3";
            label3.Size = new Size(189, 30);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial";
            // 
            // txtIncrementoSalarial
            // 
            txtIncrementoSalarial.Location = new Point(36, 370);
            txtIncrementoSalarial.Name = "txtIncrementoSalarial";
            txtIncrementoSalarial.Size = new Size(226, 35);
            txtIncrementoSalarial.TabIndex = 5;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(37, 420);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(225, 42);
            btnIncrementarSalarios.TabIndex = 6;
            btnIncrementarSalarios.Text = "Incrementar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // Form09IncrementarSalarioEmpleados
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 474);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(txtIncrementoSalarial);
            Controls.Add(label3);
            Controls.Add(lsvEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form09IncrementarSalarioEmpleados";
            Text = "Form09IncrementarSalarioEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListView lsvEmpleados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label3;
        private TextBox txtIncrementoSalarial;
        private Button btnIncrementarSalarios;
    }
}