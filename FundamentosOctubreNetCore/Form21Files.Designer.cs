﻿namespace FundamentosOctubreNetCore
{
    partial class Form21Files
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
            txtContenido = new RichTextBox();
            btnLeerFichero = new Button();
            btnGuardarFichero = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(213, 30);
            label1.TabIndex = 0;
            label1.Text = "Contenido del fichero";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(26, 48);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(505, 325);
            txtContenido.TabIndex = 1;
            txtContenido.Text = "";
            // 
            // btnLeerFichero
            // 
            btnLeerFichero.Location = new Point(578, 61);
            btnLeerFichero.Name = "btnLeerFichero";
            btnLeerFichero.Size = new Size(165, 62);
            btnLeerFichero.TabIndex = 2;
            btnLeerFichero.Text = "Leer fichero";
            btnLeerFichero.UseVisualStyleBackColor = true;
            btnLeerFichero.Click += btnLeerFichero_Click;
            // 
            // btnGuardarFichero
            // 
            btnGuardarFichero.Location = new Point(579, 145);
            btnGuardarFichero.Name = "btnGuardarFichero";
            btnGuardarFichero.Size = new Size(164, 70);
            btnGuardarFichero.TabIndex = 3;
            btnGuardarFichero.Text = "Guardar fichero";
            btnGuardarFichero.UseVisualStyleBackColor = true;
            btnGuardarFichero.Click += btnGuardarFichero_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 398);
            Controls.Add(btnGuardarFichero);
            Controls.Add(btnLeerFichero);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtContenido;
        private Button btnLeerFichero;
        private Button btnGuardarFichero;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}