namespace FundamentosOctubreNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //AQUI ES DONDE HAREMOS LAS ACCIONES CUANDO SE PULSE SOBRE EL BOTON
            //SOLAMENTE PODREMOS ESCRIBIR AQUI, ENTRE LAS LLAVES.
            //EN NINGUN OTRO SITIO
            this.txtNombre.Text = "Soy un texto";
            this.txtNombre.Width = 800;

            this.txtNombre.Location = new Point(100, 100);

            this.txtNombre.TextAlign = HorizontalAlignment.Center;
        }
    }
}
