using Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteForm
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
