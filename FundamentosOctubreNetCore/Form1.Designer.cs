namespace FundamentosOctubreNetCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPulsar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.BackColor = Color.FromArgb(255, 192, 255);
            btnPulsar.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPulsar.Location = new Point(41, 103);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(262, 108);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar para algo...";
            btnPulsar.UseVisualStyleBackColor = false;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(45, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 35);
            txtNombre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 335);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnPulsar);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private Label label1;
        private TextBox txtNombre;
    }
}
