namespace FundamentosOctubreNetCore
{
    partial class Form17SumarNumerosListBox
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
            lstNumeros = new ListBox();
            label2 = new Label();
            txtNumero = new TextBox();
            btnAgregarNumero = new Button();
            label3 = new Label();
            txtSumaTotal = new TextBox();
            label4 = new Label();
            txtSumaPares = new TextBox();
            label5 = new Label();
            txtSumaImpares = new TextBox();
            btnResumen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 17);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 30;
            lstNumeros.Location = new Point(29, 55);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(295, 334);
            lstNumeros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 25);
            label2.Name = "label2";
            label2.Size = new Size(190, 30);
            label2.TabIndex = 2;
            label2.Text = "Introduzca número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(404, 61);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(272, 35);
            txtNumero.TabIndex = 3;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(404, 107);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(272, 51);
            btnAgregarNumero.TabIndex = 4;
            btnAgregarNumero.Text = "Nuevo número";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            btnAgregarNumero.KeyDown += btnAgregarNumero_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 178);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 5;
            label3.Text = "Suma total";
            // 
            // txtSumaTotal
            // 
            txtSumaTotal.Location = new Point(351, 211);
            txtSumaTotal.Name = "txtSumaTotal";
            txtSumaTotal.Size = new Size(160, 35);
            txtSumaTotal.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 255);
            label4.Name = "label4";
            label4.Size = new Size(121, 30);
            label4.TabIndex = 7;
            label4.Text = "Suma pares";
            // 
            // txtSumaPares
            // 
            txtSumaPares.Location = new Point(353, 284);
            txtSumaPares.Name = "txtSumaPares";
            txtSumaPares.Size = new Size(158, 35);
            txtSumaPares.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 327);
            label5.Name = "label5";
            label5.Size = new Size(144, 30);
            label5.TabIndex = 9;
            label5.Text = "Suma impares";
            // 
            // txtSumaImpares
            // 
            txtSumaImpares.Location = new Point(356, 354);
            txtSumaImpares.Name = "txtSumaImpares";
            txtSumaImpares.Size = new Size(155, 35);
            txtSumaImpares.TabIndex = 10;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(538, 173);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(138, 48);
            btnResumen.TabIndex = 11;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // Form17SumarNumerosListBox
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 430);
            Controls.Add(btnResumen);
            Controls.Add(txtSumaImpares);
            Controls.Add(label5);
            Controls.Add(txtSumaPares);
            Controls.Add(label4);
            Controls.Add(txtSumaTotal);
            Controls.Add(label3);
            Controls.Add(btnAgregarNumero);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form17SumarNumerosListBox";
            Text = "Form17SumarNumerosListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Label label2;
        private TextBox txtNumero;
        private Button btnResumen;
        private Label label3;
        private TextBox txtSumaTotal;
        private Label label4;
        private TextBox txtSumaPares;
        private Label label5;
        private TextBox txtSumaImpares;
        private Button btnAgregarNumero;
    }
}