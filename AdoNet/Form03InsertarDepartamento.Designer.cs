namespace AdoNet
{
    partial class Form03InsertarDepartamento
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
            txtIdDepartamento = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            btnInsertarDepartamento = new Button();
            lblMensaje = new Label();
            btnInsertarDepartamentoParams = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "Id departamento";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(30, 45);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(100, 35);
            txtIdDepartamento.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 35);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 174);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(37, 205);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(274, 35);
            txtLocalidad.TabIndex = 5;
            // 
            // btnInsertarDepartamento
            // 
            btnInsertarDepartamento.Location = new Point(35, 261);
            btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            btnInsertarDepartamento.Size = new Size(276, 58);
            btnInsertarDepartamento.TabIndex = 6;
            btnInsertarDepartamento.Text = "Insertar departamento";
            btnInsertarDepartamento.UseVisualStyleBackColor = true;
            btnInsertarDepartamento.Click += btnInsertarDepartamento_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(35, 431);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = "lblMensaje";
            // 
            // btnInsertarDepartamentoParams
            // 
            btnInsertarDepartamentoParams.BackColor = Color.FromArgb(255, 255, 192);
            btnInsertarDepartamentoParams.Location = new Point(36, 331);
            btnInsertarDepartamentoParams.Name = "btnInsertarDepartamentoParams";
            btnInsertarDepartamentoParams.Size = new Size(275, 85);
            btnInsertarDepartamentoParams.TabIndex = 8;
            btnInsertarDepartamentoParams.Text = "Insertar departamento parámetros";
            btnInsertarDepartamentoParams.UseVisualStyleBackColor = false;
            btnInsertarDepartamentoParams.Click += btnInsertarDepartamentoParams_Click;
            // 
            // Form03InsertarDepartamento
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 497);
            Controls.Add(btnInsertarDepartamentoParams);
            Controls.Add(lblMensaje);
            Controls.Add(btnInsertarDepartamento);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtIdDepartamento);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03InsertarDepartamento";
            Text = "Form03InsertarDepartamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdDepartamento;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Button btnInsertarDepartamento;
        private Label lblMensaje;
        private Button btnInsertarDepartamentoParams;
    }
}