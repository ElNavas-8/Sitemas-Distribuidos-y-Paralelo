using ServiceReference1;

namespace CountryNames
{
    public partial class Form1 : Form
    {
        private readonly Button loadCountriesButton;
        private readonly ListBox countriesListBox;

        public Form1()
        {
            InitializeComponent();

            Text = "Países";
            StartPosition = FormStartPosition.CenterScreen;

            loadCountriesButton = new Button
            {
                AutoSize = true,
                Location = new Point(65, 90),
                Text = "Cargar países"
            };

            countriesListBox = new ListBox
            {
                Anchor = AnchorStyles.Top |
                         AnchorStyles.Bottom |
                         AnchorStyles.Left |
                         AnchorStyles.Right,
                Location = new Point(65, 135),
                Size = new Size(650, 250)
            };

            loadCountriesButton.Click += LoadCountriesButton_Click;

            Controls.Add(loadCountriesButton);
            Controls.Add(countriesListBox);

            label1.Text = "Países disponibles:";
        }

        private async void LoadCountriesButton_Click(object? sender, EventArgs e)
        {
            loadCountriesButton.Enabled = false;
            countriesListBox.Items.Clear();
            countriesListBox.Items.Add("Consultando el servicio...");

            CountryInfoPortTypeClient? client = null;

            try
            {
                client = new CountryInfoPortTypeClient();

                ListOfCountryNamesByNameResponse response =
                    await client.ListOfCountryNamesByNameAsync();

                CountryCodeAndName[]? countries =
                    response.ListOfCountryNamesByNameResult;

                countriesListBox.Items.Clear();

                if (countries is null || countries.Length == 0)
                {
                    countriesListBox.Items.Add("La API no devolvió países.");
                    return;
                }

                foreach (CountryCodeAndName country in countries)
                {
                    countriesListBox.Items.Add(
                        $"{country.sISOCode} - {country.sName}");
                }

                client.Close();
                client = null;
            }
            catch (Exception exception)
            {
                client?.Abort();

                countriesListBox.Items.Clear();
                countriesListBox.Items.Add(
                    $"Error al consumir la API: {exception.Message}");
            }
            finally
            {
                loadCountriesButton.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
