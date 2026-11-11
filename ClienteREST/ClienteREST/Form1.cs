using System.Text.Json;

namespace ClienteREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTodosLosCarritos_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://dummyjson.com/carts");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string resultado = await response.Content.ReadAsStringAsync();
            var elementos = JsonSerializer.Deserialize<Carts>(resultado);
        }

        private async void btnCrearCarrito_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://dummyjson.com/carts/add");
            Cart nuevoCart = new Cart();
            nuevoCart.id = 187;
            nuevoCart.userId = 1;
            string cartJson = JsonSerializer.Serialize(nuevoCart);
            //var content = new StringContent("{\n    \"userId\": 1,\n    \"products\": [\n        {\n            \"id\": 144,\n            \"quantity\": 4\n        },\n        {\n            \"id\": 98,\n            \"quantity\": 1\n        }\n    ]\n}", null, "application/json");
            request.Content = new StringContent(cartJson);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string resultado = await response.Content.ReadAsStringAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DummyJson dummyJson = new DummyJson();
            GetAllCartsAsync(null, null, string.Empty, string.Empty, null, null);
        }
    }
}
