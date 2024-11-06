namespace AdoNet
{
    partial class Form09ClasesDepartamentos
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
            lstDepartamentos = new ListBox();
            label2 = new Label();
            txtIdDepartamento = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 30;
            lstDepartamentos.Location = new Point(33, 58);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(547, 424);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(646, 27);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 2;
            label2.Text = "Id departamento";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(652, 59);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(100, 35);
            txtIdDepartamento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(654, 118);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(655, 153);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(301, 35);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 213);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(659, 248);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(297, 35);
            txtLocalidad.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(659, 314);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(297, 49);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(659, 381);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(297, 50);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(660, 447);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(296, 48);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form09ClasesDepartamentos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 507);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtIdDepartamento);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form09ClasesDepartamentos";
            Text = "Form09ClasesDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private TextBox txtIdDepartamento;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}