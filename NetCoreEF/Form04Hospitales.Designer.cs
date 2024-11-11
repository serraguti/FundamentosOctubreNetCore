namespace NetCoreEF
{
    partial class Form04Hospitales
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
            lstHospitales = new ListBox();
            btnCargarHospitales = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 88);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 30;
            lstHospitales.Location = new Point(31, 120);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(398, 394);
            lstHospitales.TabIndex = 1;
            // 
            // btnCargarHospitales
            // 
            btnCargarHospitales.Location = new Point(33, 20);
            btnCargarHospitales.Name = "btnCargarHospitales";
            btnCargarHospitales.Size = new Size(266, 52);
            btnCargarHospitales.TabIndex = 2;
            btnCargarHospitales.Text = "Cargar hospitales";
            btnCargarHospitales.UseVisualStyleBackColor = true;
            btnCargarHospitales.Click += btnCargarHospitales_Click;
            // 
            // Form04Hospitales
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 548);
            Controls.Add(btnCargarHospitales);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04Hospitales";
            Text = "Form04Hospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Button btnCargarHospitales;
    }
}