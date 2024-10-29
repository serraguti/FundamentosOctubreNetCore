namespace FundamentosOctubreNetCore
{
    partial class Form05DiaNacimiento
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
            txtDia = new TextBox();
            label2 = new Label();
            txtMes = new TextBox();
            label3 = new Label();
            txtAnyo = new TextBox();
            btnCalcularDiaNacimiento = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(44, 30);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(132, 28);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 35);
            txtDia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(132, 86);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 35);
            txtMes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 146);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 4;
            label3.Text = "Año";
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(132, 141);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 35);
            txtAnyo.TabIndex = 5;
            // 
            // btnCalcularDiaNacimiento
            // 
            btnCalcularDiaNacimiento.Location = new Point(279, 67);
            btnCalcularDiaNacimiento.Name = "btnCalcularDiaNacimiento";
            btnCalcularDiaNacimiento.Size = new Size(300, 64);
            btnCalcularDiaNacimiento.TabIndex = 6;
            btnCalcularDiaNacimiento.Text = "Calcular dia nacimiento";
            btnCalcularDiaNacimiento.UseVisualStyleBackColor = true;
            btnCalcularDiaNacimiento.Click += btnCalcularDiaNacimiento_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(47, 211);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(140, 30);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "lblDiaSemana";
            // 
            // Form05DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 276);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcularDiaNacimiento);
            Controls.Add(txtAnyo);
            Controls.Add(label3);
            Controls.Add(txtMes);
            Controls.Add(label2);
            Controls.Add(txtDia);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form05DiaNacimiento";
            Text = "Form05DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDia;
        private Label label2;
        private TextBox txtMes;
        private Label label3;
        private TextBox txtAnyo;
        private Button btnCalcularDiaNacimiento;
        private Label lblDiaSemana;
    }
}