using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ClienteWinForms // Asegúrate de que coincida con el namespace de tu proyecto
{
    public partial class Form1 : Form
    {
        private HttpClient httpClient;
        private ApiServicio.MiClienteWeb clienteRest;

        public Form1()
        {
            InitializeComponent();

            httpClient = new HttpClient();

            // 1. Pasamos la URL base como primer parámetro y el httpClient como segundo
            clienteRest = new ApiServicio.MiClienteWeb("http://localhost:5182", httpClient);
        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                // 2. Usamos el nombre exacto del método generado: GetWeatherForecastAsync
                var resultados = await clienteRest.GetWeatherForecastAsync();

                MessageBox.Show($"¡Conexión exitosa! Se descargaron {resultados.Count} registros.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}