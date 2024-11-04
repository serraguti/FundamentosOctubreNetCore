namespace FundamentosOctubreNetCore
{
    partial class Form25SerializarSimple
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            btnGuardarMascota = new Button();
            btnLeerMascota = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 35);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 96);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(24, 128);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(241, 35);
            txtRaza.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 179);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(28, 210);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 35);
            txtEdad.TabIndex = 5;
            // 
            // btnGuardarMascota
            // 
            btnGuardarMascota.Location = new Point(376, 45);
            btnGuardarMascota.Name = "btnGuardarMascota";
            btnGuardarMascota.Size = new Size(256, 68);
            btnGuardarMascota.TabIndex = 6;
            btnGuardarMascota.Text = "Guardar mascota";
            btnGuardarMascota.UseVisualStyleBackColor = true;
            // 
            // btnLeerMascota
            // 
            btnLeerMascota.Location = new Point(377, 133);
            btnLeerMascota.Name = "btnLeerMascota";
            btnLeerMascota.Size = new Size(255, 65);
            btnLeerMascota.TabIndex = 7;
            btnLeerMascota.Text = "Leer mascota";
            btnLeerMascota.UseVisualStyleBackColor = true;
            // 
            // Form25SerializarSimple
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 287);
            Controls.Add(btnLeerMascota);
            Controls.Add(btnGuardarMascota);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form25SerializarSimple";
            Text = "Form25SerializarSimple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Label label3;
        private TextBox txtEdad;
        private Button btnGuardarMascota;
        private Button btnLeerMascota;
    }
}