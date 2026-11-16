using System.Net.Http;

namespace ClienteREST
{
    public partial class Form1 : Form
    {

        private HttpClient httpClient;
        private MiPrimerServicioREST clienteRest;
        public Form1()
        {
            InitializeComponent();

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:5182/"); // Tu URL base

            clienteRest = new MiPrimerServicioREST(httpClient);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var resultados = await clienteRest.WeatherForecastAsync();
                // resultados es una colección que ya está convertida a objetos C#
                MessageBox.Show($"Recibidos {resultados.Count} registros del clima.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
