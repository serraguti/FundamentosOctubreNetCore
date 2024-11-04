namespace FundamentosOctubreNetCore
{
    partial class Form20TestClases
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
            lstPropiedades = new ListBox();
            btnCrearPersona = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 0;
            label1.Text = "Propiedades persona";
            // 
            // lstPropiedades
            // 
            lstPropiedades.FormattingEnabled = true;
            lstPropiedades.ItemHeight = 30;
            lstPropiedades.Location = new Point(38, 56);
            lstPropiedades.Name = "lstPropiedades";
            lstPropiedades.Size = new Size(751, 304);
            lstPropiedades.TabIndex = 1;
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(38, 377);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(231, 48);
            btnCrearPersona.TabIndex = 2;
            btnCrearPersona.Text = "Crear persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 476);
            Controls.Add(btnCrearPersona);
            Controls.Add(lstPropiedades);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstPropiedades;
        private Button btnCrearPersona;
    }
}