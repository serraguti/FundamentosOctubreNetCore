namespace FundamentosOctubreNetCore
{
    partial class Form26SerializarColeccion
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
            lstMascotas = new ListBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label4 = new Label();
            txtEdad = new TextBox();
            btnNuevaMascota = new Button();
            btnGuardarDatos = new Button();
            btnLeerDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 0;
            label1.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 30;
            lstMascotas.Location = new Point(25, 47);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(252, 334);
            lstMascotas.TabIndex = 1;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 17);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(322, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 35);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 95);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 4;
            label3.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(326, 126);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(243, 35);
            txtRaza.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 180);
            label4.Name = "label4";
            label4.Size = new Size(59, 30);
            label4.TabIndex = 6;
            label4.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(329, 213);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 35);
            txtEdad.TabIndex = 7;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(329, 269);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(240, 54);
            btnNuevaMascota.TabIndex = 8;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Location = new Point(25, 402);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(217, 50);
            btnGuardarDatos.TabIndex = 9;
            btnGuardarDatos.Text = "Guardar datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(274, 402);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(230, 50);
            btnLeerDatos.TabIndex = 10;
            btnLeerDatos.Text = "Leer datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // Form26SerializarColeccion
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 492);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnGuardarDatos);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtRaza);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lstMascotas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form26SerializarColeccion";
            Text = "Form26SerializarColeccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstMascotas;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtRaza;
        private Label label4;
        private TextBox txtEdad;
        private Button btnNuevaMascota;
        private Button btnGuardarDatos;
        private Button btnLeerDatos;
    }
}