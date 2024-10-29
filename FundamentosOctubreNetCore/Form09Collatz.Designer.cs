namespace FundamentosOctubreNetCore
{
    partial class Form09Collatz
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
            btnCollatz = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(203, 42);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(123, 35);
            txtNumero.TabIndex = 1;
            // 
            // btnCollatz
            // 
            btnCollatz.Location = new Point(125, 109);
            btnCollatz.Name = "btnCollatz";
            btnCollatz.Size = new Size(321, 65);
            btnCollatz.TabIndex = 2;
            btnCollatz.Text = "Conjetura Collatz";
            btnCollatz.UseVisualStyleBackColor = true;
            btnCollatz.Click += btnCollatz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 192);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 3;
            label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(49, 222);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(472, 230);
            txtResultado.TabIndex = 4;
            // 
            // Form09Collatz
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 476);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(btnCollatz);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form09Collatz";
            Text = "Form09Collatz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnCollatz;
        private Label label2;
        private TextBox txtResultado;
    }
}