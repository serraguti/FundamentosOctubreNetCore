namespace NetCoreEF
{
    partial class Form08CrudDepartamentos
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
            label2 = new Label();
            txtIdDepartamento = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            btnModificarDepartamento = new Button();
            btnEliminarDepartamento = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lsvDepartamentos
            // 
            lsvDepartamentos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvDepartamentos.FullRowSelect = true;
            lsvDepartamentos.Location = new Point(23, 56);
            lsvDepartamentos.Name = "lsvDepartamentos";
            lsvDepartamentos.Size = new Size(614, 328);
            lsvDepartamentos.TabIndex = 1;
            lsvDepartamentos.UseCompatibleStateImageBehavior = false;
            lsvDepartamentos.View = View.Details;
            lsvDepartamentos.SelectedIndexChanged += lsvDepartamentos_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOMBRE";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "LOCALIDAD";
            columnHeader3.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(695, 26);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 2;
            label2.Text = "Id departamento";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(701, 55);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(140, 35);
            txtIdDepartamento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(702, 108);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(705, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 35);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(705, 198);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(706, 229);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(234, 35);
            txtLocalidad.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(707, 286);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(233, 54);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar departamento";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnModificarDepartamento
            // 
            btnModificarDepartamento.Location = new Point(709, 357);
            btnModificarDepartamento.Name = "btnModificarDepartamento";
            btnModificarDepartamento.Size = new Size(231, 75);
            btnModificarDepartamento.TabIndex = 9;
            btnModificarDepartamento.Text = "Modificar departamento";
            btnModificarDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDepartamento
            // 
            btnEliminarDepartamento.BackColor = Color.Red;
            btnEliminarDepartamento.ForeColor = Color.White;
            btnEliminarDepartamento.Location = new Point(25, 401);
            btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            btnEliminarDepartamento.Size = new Size(246, 54);
            btnEliminarDepartamento.TabIndex = 10;
            btnEliminarDepartamento.Text = "Eliminar departamento";
            btnEliminarDepartamento.UseVisualStyleBackColor = false;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 540);
            Controls.Add(btnEliminarDepartamento);
            Controls.Add(btnModificarDepartamento);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtIdDepartamento);
            Controls.Add(label2);
            Controls.Add(lsvDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lsvDepartamentos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label2;
        private TextBox txtIdDepartamento;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private Button btnModificarDepartamento;
        private Button btnEliminarDepartamento;
    }
}