using System;

namespace Actividad3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            lstPrimos.Items.Clear(); // Limpiar el ListBox antes de iniciar

            if (!int.TryParse(txtIniciar.Text, out int inicio) ||
                !int.TryParse(txtFin.Text, out int fin))
            {
                MessageBox.Show("Ingresa valores num�ricos v�lidos.");
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("El valor inicial debe ser menor o igual que el final.");
                return;
            }

            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    lstPrimos.Items.Add(i);
                }
            }

            if (lstPrimos.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron n�meros primos en ese rango.");
            }
        }

        //  Este m�todo ya est� fuera del m�todo del bot�n, pero dentro de la clase
        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}