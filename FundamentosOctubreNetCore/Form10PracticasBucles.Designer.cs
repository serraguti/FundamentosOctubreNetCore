namespace FundamentosOctubreNetCore
{
    partial class Form10PracticasBucles
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
            txtNumero = new TextBox();
            btnTablaMultiplicar = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            txtInicio = new TextBox();
            label4 = new Label();
            txtFin = new TextBox();
            btnNumerosImpares = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(30, 59);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(143, 35);
            txtNumero.TabIndex = 1;
            // 
            // btnTablaMultiplicar
            // 
            btnTablaMultiplicar.Location = new Point(29, 105);
            btnTablaMultiplicar.Name = "btnTablaMultiplicar";
            btnTablaMultiplicar.Size = new Size(212, 66);
            btnTablaMultiplicar.TabIndex = 2;
            btnTablaMultiplicar.Text = "Tabla multiplicar";
            btnTablaMultiplicar.UseVisualStyleBackColor = true;
            btnTablaMultiplicar.Click += btnTablaMultiplicar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 208);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 3;
            label2.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(35, 244);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(495, 142);
            txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 18);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 5;
            label3.Text = "Inicio";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(303, 50);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(163, 35);
            txtInicio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 96);
            label4.Name = "label4";
            label4.Size = new Size(40, 30);
            label4.TabIndex = 7;
            label4.Text = "Fin";
            // 
            // txtFin
            // 
            txtFin.Location = new Point(304, 126);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(162, 35);
            txtFin.TabIndex = 8;
            // 
            // btnNumerosImpares
            // 
            btnNumerosImpares.Location = new Point(305, 176);
            btnNumerosImpares.Name = "btnNumerosImpares";
            btnNumerosImpares.Size = new Size(225, 47);
            btnNumerosImpares.TabIndex = 9;
            btnNumerosImpares.Text = "Números impares";
            btnNumerosImpares.UseVisualStyleBackColor = true;
            btnNumerosImpares.Click += btnNumerosImpares_Click;
            // 
            // Form10PracticasBucles
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 398);
            Controls.Add(btnNumerosImpares);
            Controls.Add(txtFin);
            Controls.Add(label4);
            Controls.Add(txtInicio);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(btnTablaMultiplicar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form10PracticasBucles";
            Text = "Form10PracticasBucles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnTablaMultiplicar;
        private Label label2;
        private TextBox txtResultado;
        private Label label3;
        private TextBox txtInicio;
        private Label label4;
        private TextBox txtFin;
        private Button btnNumerosImpares;
    }
}