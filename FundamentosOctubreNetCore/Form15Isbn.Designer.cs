namespace FundamentosOctubreNetCore
{
    partial class Form15Isbn
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
            txtIsbn = new TextBox();
            btnComprobarIsbn = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 0;
            label1.Text = "Número ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(35, 54);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(287, 35);
            txtIsbn.TabIndex = 1;
            // 
            // btnComprobarIsbn
            // 
            btnComprobarIsbn.Location = new Point(34, 98);
            btnComprobarIsbn.Name = "btnComprobarIsbn";
            btnComprobarIsbn.Size = new Size(288, 52);
            btnComprobarIsbn.TabIndex = 2;
            btnComprobarIsbn.Text = "Comprobar Isbn";
            btnComprobarIsbn.UseVisualStyleBackColor = true;
            btnComprobarIsbn.Click += btnComprobarIsbn_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(36, 167);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(126, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form15Isbn
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 243);
            Controls.Add(lblResultado);
            Controls.Add(btnComprobarIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form15Isbn";
            Text = "Form15Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Button btnComprobarIsbn;
        private Label lblResultado;
    }
}