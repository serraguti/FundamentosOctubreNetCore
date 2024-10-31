namespace FundamentosOctubreNetCore
{
    partial class Form19SumarBotonesNumeros
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            lblSuma = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 21);
            button1.Name = "button1";
            button1.Size = new Size(84, 64);
            button1.TabIndex = 0;
            button1.Text = "14";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(168, 21);
            button2.Name = "button2";
            button2.Size = new Size(84, 64);
            button2.TabIndex = 1;
            button2.Text = "147";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(290, 21);
            button3.Name = "button3";
            button3.Size = new Size(84, 64);
            button3.TabIndex = 2;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(395, 21);
            button4.Name = "button4";
            button4.Size = new Size(84, 64);
            button4.TabIndex = 3;
            button4.Text = "88";
            button4.UseVisualStyleBackColor = true;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.ForeColor = Color.Blue;
            lblSuma.Location = new Point(48, 130);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(24, 30);
            lblSuma.TabIndex = 4;
            lblSuma.Text = "0";
            // 
            // Form19SumarBotonesNumeros
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 197);
            Controls.Add(lblSuma);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form19SumarBotonesNumeros";
            Text = "Form19SumarBotonesNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblSuma;
    }
}