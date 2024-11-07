namespace AdoNet
{
    partial class Form10DepartamentosListView
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
            lsvDepartamentos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lsvDepartamentos
            // 
            lsvDepartamentos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvDepartamentos.FullRowSelect = true;
            lsvDepartamentos.Location = new Point(29, 52);
            lsvDepartamentos.Name = "lsvDepartamentos";
            lsvDepartamentos.Size = new Size(538, 402);
            lsvDepartamentos.TabIndex = 1;
            lsvDepartamentos.UseCompatibleStateImageBehavior = false;
            lsvDepartamentos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOMBRE";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "LOCALIDAD";
            columnHeader3.Width = 180;
            // 
            // Form10DepartamentosListView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 482);
            Controls.Add(lsvDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form10DepartamentosListView";
            Text = "Form10DepartamentosListView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvDepartamentos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}