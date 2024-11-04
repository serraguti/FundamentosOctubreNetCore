using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosOctubreNetCore
{
    public partial class Form24ColeccionCoches : Form
    {
        List<Coche> coleccionCoches;

        public Form24ColeccionCoches()
        {
            InitializeComponent();
            this.coleccionCoches = new List<Coche>();
        }

        private void btnGuardarCoche_Click(object sender, EventArgs e)
        {
            Coche car = new Coche();
            car.Marca = this.txtMarca.Text;
            car.Modelo = this.txtModelo.Text;
            car.Velocidad = int.Parse(this.txtVelocidad.Text);
            this.coleccionCoches.Add(car);
            this.lblMensaje.Text = "Coches almacenados: " + this.coleccionCoches.Count;
            this.txtVelocidad.Text = "";
            this.txtMarca.Text = "";
            this.txtModelo.Text = "";
        }

        private void btnMostrarCoches_Click(object sender, EventArgs e)
        {
            this.lstCoches.Items.Clear();
            foreach (Coche coche in this.coleccionCoches)
            {
                this.lstCoches.Items.Add(coche.Marca + " " + coche.Modelo);
            }
        }

        private void lstCoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstCoches.SelectedIndex != -1)
            {
                int index = this.lstCoches.SelectedIndex;
                Coche car = this.coleccionCoches[index];
                this.txtMarca.Text = car.Marca;
                this.txtModelo.Text = car.Modelo;
                this.txtVelocidad.Text = car.Velocidad.ToString();
            }
        }
    }
}
