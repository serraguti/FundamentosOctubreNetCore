namespace FundamentosOctubreNetCore
{
    partial class Form02PositivoNegativoCero
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
            btnEvaluarNumero = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(220, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(45, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(208, 35);
            txtNumero.TabIndex = 1;
            // 
            // btnEvaluarNumero
            // 
            btnEvaluarNumero.Location = new Point(45, 110);
            btnEvaluarNumero.Name = "btnEvaluarNumero";
            btnEvaluarNumero.Size = new Size(208, 62);
            btnEvaluarNumero.TabIndex = 2;
            btnEvaluarNumero.Text = "Evaluar número";
            btnEvaluarNumero.UseVisualStyleBackColor = true;
            btnEvaluarNumero.Click += btnEvaluarNumero_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(46, 186);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(126, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form02PositivoNegativoCero
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 266);
            Controls.Add(lblResultado);
            Controls.Add(btnEvaluarNumero);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form02PositivoNegativoCero";
            Text = "Form02PositivoNegativoCero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnEvaluarNumero;
        private Label lblResultado;
    }
}