namespace FundamentosOctubreNetCore
{
    partial class Form08NumerosPares
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
            btnNumerosPares = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnNumerosPares
            // 
            btnNumerosPares.Location = new Point(62, 32);
            btnNumerosPares.Name = "btnNumerosPares";
            btnNumerosPares.Size = new Size(491, 91);
            btnNumerosPares.TabIndex = 0;
            btnNumerosPares.Text = "Números Pares 1 - 50";
            btnNumerosPares.UseVisualStyleBackColor = true;
            btnNumerosPares.Click += btnNumerosPares_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(64, 145);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(489, 162);
            txtResultado.TabIndex = 1;
            // 
            // Form08NumerosPares
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 328);
            Controls.Add(txtResultado);
            Controls.Add(btnNumerosPares);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form08NumerosPares";
            Text = "Form08NumerosPares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumerosPares;
        private TextBox txtResultado;
    }
}