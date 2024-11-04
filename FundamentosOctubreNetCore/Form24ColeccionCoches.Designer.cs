namespace FundamentosOctubreNetCore
{
    partial class Form24ColeccionCoches
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
            lstCoches = new ListBox();
            lblMensaje = new Label();
            label3 = new Label();
            txtMarca = new TextBox();
            label4 = new Label();
            txtModelo = new TextBox();
            label5 = new Label();
            txtVelocidad = new TextBox();
            btnGuardarCoche = new Button();
            btnMostrarCoches = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 0;
            label1.Text = "Coches";
            // 
            // lstCoches
            // 
            lstCoches.FormattingEnabled = true;
            lstCoches.ItemHeight = 30;
            lstCoches.Location = new Point(24, 50);
            lstCoches.Name = "lstCoches";
            lstCoches.Size = new Size(288, 334);
            lstCoches.TabIndex = 1;
            lstCoches.SelectedIndexChanged += lstCoches_SelectedIndexChanged;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(26, 410);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "lblMensaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 14);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 3;
            label3.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(358, 45);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(269, 35);
            txtMarca.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 93);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 5;
            label4.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(362, 123);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(265, 35);
            txtModelo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 172);
            label5.Name = "label5";
            label5.Size = new Size(103, 30);
            label5.TabIndex = 7;
            label5.Text = "Velocidad";
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(365, 206);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(100, 35);
            txtVelocidad.TabIndex = 8;
            // 
            // btnGuardarCoche
            // 
            btnGuardarCoche.Location = new Point(365, 261);
            btnGuardarCoche.Name = "btnGuardarCoche";
            btnGuardarCoche.Size = new Size(262, 58);
            btnGuardarCoche.TabIndex = 9;
            btnGuardarCoche.Text = "Guardar coche";
            btnGuardarCoche.UseVisualStyleBackColor = true;
            btnGuardarCoche.Click += btnGuardarCoche_Click;
            // 
            // btnMostrarCoches
            // 
            btnMostrarCoches.Location = new Point(365, 330);
            btnMostrarCoches.Name = "btnMostrarCoches";
            btnMostrarCoches.Size = new Size(262, 54);
            btnMostrarCoches.TabIndex = 10;
            btnMostrarCoches.Text = "Mostrar coches";
            btnMostrarCoches.UseVisualStyleBackColor = true;
            btnMostrarCoches.Click += btnMostrarCoches_Click;
            // 
            // Form24ColeccionCoches
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 474);
            Controls.Add(btnMostrarCoches);
            Controls.Add(btnGuardarCoche);
            Controls.Add(txtVelocidad);
            Controls.Add(label5);
            Controls.Add(txtModelo);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(lblMensaje);
            Controls.Add(lstCoches);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form24ColeccionCoches";
            Text = "Form24ColeccionCoches";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstCoches;
        private Label lblMensaje;
        private Label label3;
        private TextBox txtMarca;
        private Label label4;
        private TextBox txtModelo;
        private Label label5;
        private TextBox txtVelocidad;
        private Button btnGuardarCoche;
        private Button btnMostrarCoches;
    }
}