namespace Actividad3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse( txtNumero.Text, out int numero))
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
                return;
            }

            if (numero < 2)
            {
                MessageBox.Show("No es primo.");
                return;
            }

            bool esPrimo = true;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
                MessageBox.Show($"{numero} es un n�mero primo.");
            else
                MessageBox.Show($"{numero} no es un n�mero primo.");
        }

    }
}
