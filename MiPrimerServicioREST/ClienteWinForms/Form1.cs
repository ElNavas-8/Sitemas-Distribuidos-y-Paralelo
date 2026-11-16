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

        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                string monedaOrigen = cmbDe.Text;   // Ej: "USD"
                string monedaDestino = cmbA.Text;   // Ej: "EUR"
                double cantidad = double.Parse(txtCantidad.Text);

                // Escribe "clienteRest." y usa IntelliSense para confirmar si se generó como MonedasAsync o GetMonedasAsync
                double resultado = await clienteRest.MonedasAsync(monedaOrigen, monedaDestino, cantidad);

                MessageBox.Show($"Resultado: {resultado} {monedaDestino}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conversión: " + ex.Message);
            }
        }
    }
}