namespace FundamentosOctubreNetCore
{
    partial class Form06DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            label2 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            lblDayOfWeek = new Label();
            lblDayOfYear = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 0;
            label1.Text = "Fecha actuales";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(31, 57);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(661, 35);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(32, 117);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(246, 34);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato fecha";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(88, 187);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(71, 34);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(86, 234);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(90, 34);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(88, 285);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(78, 34);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 187);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 6;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(373, 217);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(201, 35);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(372, 271);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(285, 48);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 369);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 9;
            label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(43, 398);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(649, 35);
            txtNuevaFecha.TabIndex = 10;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Location = new Point(43, 456);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(145, 30);
            lblDayOfWeek.TabIndex = 11;
            lblDayOfWeek.Text = "lblDayOfWeek";
            // 
            // lblDayOfYear
            // 
            lblDayOfYear.AutoSize = true;
            lblDayOfYear.Location = new Point(43, 505);
            lblDayOfYear.Name = "lblDayOfYear";
            lblDayOfYear.Size = new Size(133, 30);
            lblDayOfYear.TabIndex = 12;
            lblDayOfYear.Text = "lblDayOfYear";
            // 
            // Form06DateTime
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 573);
            Controls.Add(lblDayOfYear);
            Controls.Add(lblDayOfWeek);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06DateTime";
            Text = "Form06DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label3;
        private TextBox txtNuevaFecha;
        private Label lblDayOfWeek;
        private Label lblDayOfYear;
    }
}