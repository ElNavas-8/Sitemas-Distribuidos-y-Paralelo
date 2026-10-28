namespace EjemploSImpleAsync
{
    public partial class Form1 : Form
    {

        HttpClient _httpClient;
        public Form1()
        {
            InitializeComponent();
            this._httpClient = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnContenedor_Click(object sender, EventArgs e)
        {
            Task<String> promesa = this._httpClient.GetStringAsync("https://es.wikipedia.org/wiki/");
            string resultado = await promesa;
            this.textBox1.Text = resultado;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Aquí puede agregar el código que  desee ejecutar cuando cambie el texto
        }
    }
}
