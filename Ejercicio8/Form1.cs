namespace Activida3._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string texto = txtOracion.Text.Trim();
            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int cantidad = palabras.Length;
            lblResultado.Text = "Cantidad de palabras: " + cantidad.ToString();


        }
    }
}
