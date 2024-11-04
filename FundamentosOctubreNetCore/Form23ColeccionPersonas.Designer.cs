namespace FundamentosOctubreNetCore
{
    partial class Form23ColeccionPersonas
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
            lstPersonas = new ListBox();
            lblMensaje = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtEdad = new TextBox();
            btnGuardarPersona = new Button();
            btnMostrarPersonas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 0;
            label1.Text = "Personas";
            // 
            // lstPersonas
            // 
            lstPersonas.FormattingEnabled = true;
            lstPersonas.ItemHeight = 30;
            lstPersonas.Location = new Point(31, 55);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(284, 334);
            lstPersonas.TabIndex = 1;
            lstPersonas.SelectedIndexChanged += lstPersonas_SelectedIndexChanged;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(31, 412);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "lblMensaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 13);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(373, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 35);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 87);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 5;
            label4.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(375, 118);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(239, 35);
            txtApellidos.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 165);
            label5.Name = "label5";
            label5.Size = new Size(59, 30);
            label5.TabIndex = 7;
            label5.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(381, 198);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 35);
            txtEdad.TabIndex = 8;
            // 
            // btnGuardarPersona
            // 
            btnGuardarPersona.Location = new Point(381, 254);
            btnGuardarPersona.Name = "btnGuardarPersona";
            btnGuardarPersona.Size = new Size(233, 51);
            btnGuardarPersona.TabIndex = 9;
            btnGuardarPersona.Text = "Guardar persona";
            btnGuardarPersona.UseVisualStyleBackColor = true;
            btnGuardarPersona.Click += btnGuardarPersona_Click;
            // 
            // btnMostrarPersonas
            // 
            btnMostrarPersonas.Location = new Point(383, 319);
            btnMostrarPersonas.Name = "btnMostrarPersonas";
            btnMostrarPersonas.Size = new Size(231, 55);
            btnMostrarPersonas.TabIndex = 10;
            btnMostrarPersonas.Text = "Mostrar personas";
            btnMostrarPersonas.UseVisualStyleBackColor = true;
            btnMostrarPersonas.Click += btnMostrarPersonas_Click;
            // 
            // Form23ColeccionPersonas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 462);
            Controls.Add(btnMostrarPersonas);
            Controls.Add(btnGuardarPersona);
            Controls.Add(txtEdad);
            Controls.Add(label5);
            Controls.Add(txtApellidos);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(lblMensaje);
            Controls.Add(lstPersonas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form23ColeccionPersonas";
            Text = "Form23ColeccionPersonas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstPersonas;
        private Label lblMensaje;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtApellidos;
        private Label label5;
        private TextBox txtEdad;
        private Button btnGuardarPersona;
        private Button btnMostrarPersonas;
    }
}