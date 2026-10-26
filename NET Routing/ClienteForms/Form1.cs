using System;
using System.Windows.Forms;
// Agregamos las librerías necesarias del cliente original
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Comun;

namespace ClienteForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Debes vincular este método al evento Click de un botón desde el diseñador
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Código trasladado desde Program.cs
                TcpChannel canal = new TcpChannel();
                ChannelServices.RegisterChannel(canal, false);
                Type TipoRemoto = typeof(IMovieTicket);

                IMovieTicket objetoRemoto = (IMovieTicket)Activator.GetObject(
                    TipoRemoto,
                    "tcp://localhost:9998/MovieTicket");

                string resultado = objetoRemoto.GetTicketStatus("Ticket Nº: 6363");

                // Mostramos el resultado visualmente en vez de usar la consola
                MessageBox.Show(resultado, "Estado del Ticket");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}