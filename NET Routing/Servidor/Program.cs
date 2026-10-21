using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Servidor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Servidor iniciado...");

            TcpChannel canal = new TcpChannel(9998);
            ChannelServices.RegisterChannel(canal, false);

            Type tipoRemoto = typeof(MovieTicket);

            RemotingConfiguration.RegisterWellKnownServiceType(
                tipoRemoto,
                "MovieTicket",
                WellKnownObjectMode.Singleton); // o SingleCall

            Console.WriteLine("Servidor esperando peticiones...");
            Console.ReadLine();
        }
    }
}
