using Calculadora;

namespace ClienteSoap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                using CalculatorSoapClient cliente =
                    new CalculatorSoapClient(
                        CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);

                int numero1 = decimal.ToInt32(nUD1.Value);
                int numero2 = decimal.ToInt32(nUD2.Value);

                int resultado = await cliente.AddAsync(numero1, numero2);

                lblResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo consumir el servicio SOAP:{Environment.NewLine}{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
