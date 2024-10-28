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
            
            //CONVERSION DE STRING A PRIMITIVO
            string textoNumero = "12345";
            int numeroEntero = int.Parse(textoNumero);
            double numeroDecimal = double.Parse(textoNumero);

            //CONVERTIR CUALQUIER CLASE A STRING
            string dato = numeroEntero.ToString();
            string otroDato = numeroDecimal.ToString();
            string otroMas = this.btnPulsar.ToString();


            
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
