namespace Actividad3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSalida.Items.AddRange(new string[] { "Metros", "Centimetro", "Pulgadas" });
            cmbEntrada.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });

            cmbSalida.SelectedIndex = 0;
            cmbEntrada.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valor;
            if (!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Ingresa un número válido.");
                return;
            }

            string unidadEntrada = cmbEntrada.SelectedItem.ToString();
            string unidadSalida = cmbSalida.SelectedItem.ToString();

            // Convertir a metros como base
            double valorEnMetros = unidadEntrada switch
            {
                "Metros" => valor,
                "Centímetros" => valor / 100,
                "Pulgadas" => valor * 0.0254,
                _ => 0
            };

            // Convertir de metros a unidad destino
            double resultado = unidadSalida switch
            {
                "Metros" => valorEnMetros,
                "Centímetros" => valorEnMetros * 100,
                "Pulgadas" => valorEnMetros / 0.0254,
                _ => 0
            };
            lblResultado.Text = $"{Math.Round(resultado, 4)} {unidadSalida}";

        }
    }
}