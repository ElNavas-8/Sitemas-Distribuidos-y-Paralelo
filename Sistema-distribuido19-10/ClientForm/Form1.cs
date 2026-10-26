using System.Configuration;
using System.Net.Sockets;
using System.Text;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            string origen = txtOrigen.Text.Trim();
            string destino= txtDestino.Text.Trim();
            string cantidadStr = txtCantidad.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino) || string.IsNullOrEmpty(cantidadStr))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lectura de configuración o valores por defecto
            string host = ConfigurationManager.AppSettings["host"] ?? "127.0.0.1";
            int port = int.Parse(ConfigurationManager.AppSettings["port"] ?? "13000");

            try
            {
                // Conexión al servidor TCP
                using (TcpClient client = new TcpClient(host, port))
                using (NetworkStream stream = client.GetStream())
                {
                    string xmlRequest = $"<ConvertRequest><from>{origen}</from><to>{destino}</to><units>{cantidadStr}</units></ConvertRequest>";
                    byte[] data = Encoding.ASCII.GetBytes(xmlRequest);

                    // Envío del mensaje XML
                    stream.Write(data, 0, data.Length);

                    // Recepción de la respuesta
                    byte[] responseBuffer = new byte[1024];
                    int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                    string responseData = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);

                    // Mostrar resultado en el cuadro de texto de resultados
                    txtResultado.Text = responseData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al comunicarse con el servidor:\n{ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDestino_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
