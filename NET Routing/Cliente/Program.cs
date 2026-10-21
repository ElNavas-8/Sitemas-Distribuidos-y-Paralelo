using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using Comun; 

namespace Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente iniciado...");
            TcpChannel canal = new TcpChannel();
            ChannelServices.RegisterChannel(canal, false);
            Type TipoRemoto = typeof(IMovieTicket);

            IMovieTicket objetoRemoto = (IMovieTicket)Activator.GetObject(
                TipoRemoto,
                "tcp://localhost:9998/MovieTicket");

            string resultado = objetoRemoto.GetTicketStatus("Ticket Nº: 6363");
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
