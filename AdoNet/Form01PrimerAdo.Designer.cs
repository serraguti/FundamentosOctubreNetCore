namespace AdoNet
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            lblMensaje = new Label();
            label2 = new Label();
            lstColumnas = new ListBox();
            label3 = new Label();
            lstTiposDato = new ListBox();
            label4 = new Label();
            lstApellidos = new ListBox();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(34, 32);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(184, 72);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar BBDD";
            btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(35, 116);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(183, 81);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(36, 214);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(182, 76);
            btnLeerDatos.TabIndex = 2;
            btnLeerDatos.Text = "Leer datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(37, 349);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(113, 30);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "lblMensaje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 14);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.ItemHeight = 30;
            lstColumnas.Location = new Point(257, 43);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(231, 334);
            lstColumnas.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 17);
            label3.Name = "label3";
            label3.Size = new Size(110, 30);
            label3.TabIndex = 6;
            label3.Text = "Tipos dato";
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.ItemHeight = 30;
            lstTiposDato.Location = new Point(526, 45);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(246, 334);
            lstTiposDato.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(799, 17);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 8;
            label4.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.ItemHeight = 30;
            lstApellidos.Location = new Point(804, 48);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(263, 334);
            lstApellidos.TabIndex = 9;
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 403);
            Controls.Add(lstApellidos);
            Controls.Add(label4);
            Controls.Add(lstTiposDato);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lblMensaje);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label lblMensaje;
        private Label label2;
        private ListBox lstColumnas;
        private Label label3;
        private ListBox lstTiposDato;
        private Label label4;
        private ListBox lstApellidos;
    }
}