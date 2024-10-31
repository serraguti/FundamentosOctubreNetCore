namespace FundamentosOctubreNetCore
{
    partial class Form18EventosMetodos
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
            lblRaton = new Label();
            label1 = new Label();
            txtSoloLetras = new TextBox();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(40, 25);
            button1.Name = "button1";
            button1.Size = new Size(162, 58);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(41, 94);
            button2.Name = "button2";
            button2.Size = new Size(161, 66);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(43, 170);
            button3.Name = "button3";
            button3.Size = new Size(159, 59);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(255, 192, 255);
            lblRaton.BorderStyle = BorderStyle.FixedSingle;
            lblRaton.Location = new Point(231, 31);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(561, 267);
            lblRaton.TabIndex = 3;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.Click += lblRaton_Click;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 341);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 4;
            label1.Text = "Solo letras";
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(190, 336);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(326, 35);
            txtSoloLetras.TabIndex = 5;
            txtSoloLetras.TextChanged += txtSoloLetras_TextChanged;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 390);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 6;
            label2.Text = "Solo números";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(189, 385);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(327, 35);
            txtSoloNumeros.TabIndex = 7;
            // 
            // Form18EventosMetodos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 454);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(txtSoloLetras);
            Controls.Add(label1);
            Controls.Add(lblRaton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form18EventosMetodos";
            Text = "Form18EventosMetodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblRaton;
        private Label label1;
        private TextBox txtSoloLetras;
        private Label label2;
        private TextBox txtSoloNumeros;
    }
}