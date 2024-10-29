namespace FundamentosOctubreNetCore
{
    partial class Form04MayorTresNumeros
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
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            label3 = new Label();
            txtNumero3 = new TextBox();
            btnMostrarResultados = new Button();
            lblMayor = new Label();
            lblMenor = new Label();
            lblIntermedio = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(41, 49);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(147, 35);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 94);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(44, 124);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(144, 35);
            txtNumero2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 173);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 4;
            label3.Text = "Número 3";
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(48, 203);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(140, 35);
            txtNumero3.TabIndex = 5;
            // 
            // btnMostrarResultados
            // 
            btnMostrarResultados.Location = new Point(48, 254);
            btnMostrarResultados.Name = "btnMostrarResultados";
            btnMostrarResultados.Size = new Size(474, 67);
            btnMostrarResultados.TabIndex = 6;
            btnMostrarResultados.Text = "Mostrar resultados";
            btnMostrarResultados.UseVisualStyleBackColor = true;
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(252, 47);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(94, 30);
            lblMayor.TabIndex = 7;
            lblMayor.Text = "lblMayor";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(255, 98);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(96, 30);
            lblMenor.TabIndex = 8;
            lblMenor.Text = "lblMenor";
            // 
            // lblIntermedio
            // 
            lblIntermedio.AutoSize = true;
            lblIntermedio.Location = new Point(255, 144);
            lblIntermedio.Name = "lblIntermedio";
            lblIntermedio.Size = new Size(136, 30);
            lblIntermedio.TabIndex = 9;
            lblIntermedio.Text = "lblIntermedio";
            // 
            // Form04MayorTresNumeros
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 359);
            Controls.Add(lblIntermedio);
            Controls.Add(lblMenor);
            Controls.Add(lblMayor);
            Controls.Add(btnMostrarResultados);
            Controls.Add(txtNumero3);
            Controls.Add(label3);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04MayorTresNumeros";
            Text = "Form04MayorTresNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Label label3;
        private TextBox txtNumero3;
        private Button btnMostrarResultados;
        private Label lblMayor;
        private Label lblMenor;
        private Label lblIntermedio;
    }
}