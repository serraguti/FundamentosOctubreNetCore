namespace FundamentosOctubreNetCore
{
    partial class Form22ColeccionesNoGraficas
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
            lstNombres = new ListBox();
            label2 = new Label();
            txtNuevoNombre = new TextBox();
            btnGuardarNombre = new Button();
            btnMostrarNombres = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 30;
            lstNombres.Location = new Point(27, 52);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(323, 334);
            lstNombres.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 18);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 2;
            label2.Text = "Nuevo nombre";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(443, 54);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(289, 35);
            txtNuevoNombre.TabIndex = 3;
            // 
            // btnGuardarNombre
            // 
            btnGuardarNombre.Location = new Point(443, 103);
            btnGuardarNombre.Name = "btnGuardarNombre";
            btnGuardarNombre.Size = new Size(289, 52);
            btnGuardarNombre.TabIndex = 4;
            btnGuardarNombre.Text = "Guardar nombre";
            btnGuardarNombre.UseVisualStyleBackColor = true;
            btnGuardarNombre.Click += btnGuardarNombre_Click;
            // 
            // btnMostrarNombres
            // 
            btnMostrarNombres.Location = new Point(443, 168);
            btnMostrarNombres.Name = "btnMostrarNombres";
            btnMostrarNombres.Size = new Size(289, 57);
            btnMostrarNombres.TabIndex = 5;
            btnMostrarNombres.Text = "Mostrar nombres";
            btnMostrarNombres.UseVisualStyleBackColor = true;
            btnMostrarNombres.Click += btnMostrarNombres_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(442, 255);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form22ColeccionesNoGraficas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 432);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrarNombres);
            Controls.Add(btnGuardarNombre);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label2);
            Controls.Add(lstNombres);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form22ColeccionesNoGraficas";
            Text = "Form22ColeccionesNoGraficas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNombres;
        private Label label2;
        private TextBox txtNuevoNombre;
        private Button btnGuardarNombre;
        private Button btnMostrarNombres;
        private Label lblMensaje;
    }
}