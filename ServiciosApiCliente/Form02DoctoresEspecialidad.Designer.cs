namespace ServiciosApiCliente
{
    partial class Form02DoctoresEspecialidad
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
            lstEspecialidades = new ListBox();
            label2 = new Label();
            lsvDoctores = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "Especialidades";
            // 
            // lstEspecialidades
            // 
            lstEspecialidades.FormattingEnabled = true;
            lstEspecialidades.ItemHeight = 30;
            lstEspecialidades.Location = new Point(29, 52);
            lstEspecialidades.Name = "lstEspecialidades";
            lstEspecialidades.Size = new Size(271, 334);
            lstEspecialidades.TabIndex = 1;
            lstEspecialidades.SelectedIndexChanged += lstEspecialidades_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 18);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Doctores";
            // 
            // lsvDoctores
            // 
            lsvDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvDoctores.FullRowSelect = true;
            lsvDoctores.Location = new Point(337, 51);
            lsvDoctores.Name = "lsvDoctores";
            lsvDoctores.Size = new Size(550, 335);
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
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Salario";
            columnHeader3.Width = 150;
            // 
            // Form02DoctoresEspecialidad
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 490);
            Controls.Add(lsvDoctores);
            Controls.Add(label2);
            Controls.Add(lstEspecialidades);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02DoctoresEspecialidad";
            Text = "Form02DoctoresEspecialidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstEspecialidades;
        private Label label2;
        private ListView lsvDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}