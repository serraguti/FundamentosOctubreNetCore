namespace ServiciosApiCliente
{
    partial class Form03DoctoresHospital
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
            txtIdHospital = new TextBox();
            btnBuscardoctores = new Button();
            label2 = new Label();
            lstApellidos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 0;
            label1.Text = "Id hospital";
            // 
            // txtIdHospital
            // 
            txtIdHospital.Location = new Point(23, 49);
            txtIdHospital.Name = "txtIdHospital";
            txtIdHospital.Size = new Size(180, 35);
            txtIdHospital.TabIndex = 1;
            // 
            // btnBuscardoctores
            // 
            btnBuscardoctores.Location = new Point(23, 95);
            btnBuscardoctores.Name = "btnBuscardoctores";
            btnBuscardoctores.Size = new Size(180, 43);
            btnBuscardoctores.TabIndex = 2;
            btnBuscardoctores.Text = "Buscar doctores";
            btnBuscardoctores.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 20);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 3;
            label2.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.ItemHeight = 30;
            lstApellidos.Location = new Point(256, 52);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(375, 334);
            lstApellidos.TabIndex = 4;
            // 
            // Form03DoctoresHospital
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 416);
            Controls.Add(lstApellidos);
            Controls.Add(label2);
            Controls.Add(btnBuscardoctores);
            Controls.Add(txtIdHospital);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03DoctoresHospital";
            Text = "Form03DoctoresHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdHospital;
        private Button btnBuscardoctores;
        private Label label2;
        private ListBox lstApellidos;
    }
}