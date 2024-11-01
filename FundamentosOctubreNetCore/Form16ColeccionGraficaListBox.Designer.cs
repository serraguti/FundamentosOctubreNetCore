﻿namespace FundamentosOctubreNetCore
{
    partial class Form16ColeccionGraficaListBox
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
            lstElementos = new ListBox();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblItemSeleccionado = new Label();
            lblIndexSeleccionado = new Label();
            btnRecorrerElementos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 30;
            lstElementos.Location = new Point(27, 52);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(233, 304);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 16);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 2;
            label2.Text = "Nuevo elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(330, 47);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(276, 35);
            txtNuevoElemento.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(330, 93);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(276, 49);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(330, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(277, 52);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = Color.Red;
            btnBorrarTodo.ForeColor = SystemColors.ButtonHighlight;
            btnBorrarTodo.Location = new Point(330, 229);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(276, 56);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(28, 377);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(199, 30);
            lblItemSeleccionado.TabIndex = 7;
            lblItemSeleccionado.Text = "lblItemSeleccionado";
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(28, 425);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(208, 30);
            lblIndexSeleccionado.TabIndex = 8;
            lblIndexSeleccionado.Text = "lblIndexSeleccionado";
            // 
            // btnRecorrerElementos
            // 
            btnRecorrerElementos.Location = new Point(333, 303);
            btnRecorrerElementos.Name = "btnRecorrerElementos";
            btnRecorrerElementos.Size = new Size(274, 53);
            btnRecorrerElementos.TabIndex = 9;
            btnRecorrerElementos.Text = "Recorrer elementos";
            btnRecorrerElementos.UseVisualStyleBackColor = true;
            btnRecorrerElementos.Click += btnRecorrerElementos_Click;
            // 
            // Form16ColeccionGraficaListBox
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 485);
            Controls.Add(btnRecorrerElementos);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form16ColeccionGraficaListBox";
            Text = "Form16ColeccionGraficaListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblItemSeleccionado;
        private Label lblIndexSeleccionado;
        private Button btnRecorrerElementos;
    }
}