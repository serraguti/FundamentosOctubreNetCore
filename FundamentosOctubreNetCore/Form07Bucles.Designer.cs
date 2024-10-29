namespace FundamentosOctubreNetCore
{
    partial class Form07Bucles
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
            btnEjemploFor = new Button();
            btnEjemploWhile = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnEjemploFor
            // 
            btnEjemploFor.Location = new Point(34, 39);
            btnEjemploFor.Name = "btnEjemploFor";
            btnEjemploFor.Size = new Size(201, 76);
            btnEjemploFor.TabIndex = 0;
            btnEjemploFor.Text = "Ejemplo For";
            btnEjemploFor.UseVisualStyleBackColor = true;
            btnEjemploFor.Click += btnEjemploFor_Click;
            // 
            // btnEjemploWhile
            // 
            btnEjemploWhile.Location = new Point(303, 40);
            btnEjemploWhile.Name = "btnEjemploWhile";
            btnEjemploWhile.Size = new Size(214, 75);
            btnEjemploWhile.TabIndex = 1;
            btnEjemploWhile.Text = "Ejemplo While";
            btnEjemploWhile.UseVisualStyleBackColor = true;
            btnEjemploWhile.Click += btnEjemploWhile_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(38, 145);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(479, 113);
            txtResultado.TabIndex = 2;
            // 
            // Form07Bucles
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 324);
            Controls.Add(txtResultado);
            Controls.Add(btnEjemploWhile);
            Controls.Add(btnEjemploFor);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form07Bucles";
            Text = "Form07Bucles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjemploFor;
        private Button btnEjemploWhile;
        private TextBox txtResultado;
    }
}