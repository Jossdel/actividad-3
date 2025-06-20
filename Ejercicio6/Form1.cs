using System.Diagnostics.CodeAnalysis;

namespace Actividad3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int numero) || numero <= 0)
            {
                MessageBox.Show("Ingresa un numero valido y mayor que cero.");
                return;
            }
            int sumaDivisores = 0;
            for (int i = 1; i < numero; i++) 
            {
                if (numero % i == 0)
                    sumaDivisores += i;
            }
            if (sumaDivisores == numero)
            {
                MessageBox.Show($"{numero} es un número perfecto ");
            }
            else
            {
                MessageBox.Show($"{numero} no es un número perfecto.");
            }

        }
    }
}
