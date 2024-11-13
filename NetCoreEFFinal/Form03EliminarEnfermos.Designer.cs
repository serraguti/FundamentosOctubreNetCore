namespace NetCoreEFFinal
{
    partial class Form03EliminarEnfermos
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
            lsvEnfermos = new ListView();
            btnEliminarEnfermo = new Button();
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
            label1.Location = new Point(44, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Enfermos";
            // 
            // lsvEnfermos
            // 
            lsvEnfermos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lsvEnfermos.FullRowSelect = true;
            lsvEnfermos.Location = new Point(50, 59);
            lsvEnfermos.Name = "lsvEnfermos";
            lsvEnfermos.Size = new Size(843, 318);
            lsvEnfermos.TabIndex = 1;
            lsvEnfermos.UseCompatibleStateImageBehavior = false;
            lsvEnfermos.View = View.Details;
            // 
            // btnEliminarEnfermo
            // 
            btnEliminarEnfermo.BackColor = Color.Red;
            btnEliminarEnfermo.ForeColor = Color.White;
            btnEliminarEnfermo.Location = new Point(49, 400);
            btnEliminarEnfermo.Name = "btnEliminarEnfermo";
            btnEliminarEnfermo.Size = new Size(277, 59);
            btnEliminarEnfermo.TabIndex = 2;
            btnEliminarEnfermo.Text = "Eliminar enfermo";
            btnEliminarEnfermo.UseVisualStyleBackColor = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Inscripción";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Apellido";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Sexo";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "NSS";
            columnHeader6.Width = 130;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 517);
            Controls.Add(btnEliminarEnfermo);
            Controls.Add(lsvEnfermos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvEnfermos;
        private Button btnEliminarEnfermo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}