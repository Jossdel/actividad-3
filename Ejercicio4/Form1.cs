namespace Actividad3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower().Replace(" ", "");

            // Invertir la palabra
            char[] arreglo = palabra.ToCharArray();
            Array.Reverse(arreglo);
            string invertida = new string(arreglo);

            if (palabra == invertida)
            {
                MessageBox.Show("¡Es un palíndromo!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
