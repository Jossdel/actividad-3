using System;
using System.Windows.Forms;

namespace Actividad3._2
{
    public partial class Form1 : Form
    {
        int mm = 0, ss = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmostrado.Text = "00:00";

        }
        private void reiniciar()
        {
            mm = 0;
            ss = 0;
            lblmostrado.Text = "00:00";
            txtMinutos.Text = ""; // Borra el TextBox al reiniciar
            ttemporizador.Stop();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinutos.Text, out mm) && mm >= 0)
            {
                ss = 0;
                lblmostrado.Text = mm.ToString("D2") + ":00";
                ttemporizador.Start();
            }
            else
            {
                MessageBox.Show("Introduce un número válido de minutos.");
            }


        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            ttemporizador.Stop();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void ttemporizador_Tick(object sender, EventArgs e)
        {
            if (mm == 0 && ss == 0)
            {
                ttemporizador.Stop();
                lblmostrado.Text = "00:00";
                MessageBox.Show("¡Tiempo terminado!");
                return;
            }

            if (ss == 0)
            {
                if (mm > 0)
                {
                    mm--;
                    ss = 59;
                }
            }
            else
            {
                ss--;
            }

            lblmostrado.Text = mm.ToString("D2") + ":" + ss.ToString("D2");


        }
    }
}
