using System;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

public class CurrencyServer
{
    private static object lockObject = new object();
    private static int requestCounter = 0;

    public static async Task Main(string[] args)
    {
        try
        {
            string host = ConfigurationManager.AppSettings["host"] ?? "127.0.0.1";
            IPAddress localAddr = IPAddress.Parse(host);
            string portStr = ConfigurationManager.AppSettings["port"] ?? "13000";
            int port = int.Parse(portStr);
            TcpListener server = new TcpListener(localAddr, port);

            server.Start();
            Console.WriteLine($"[SERVIDOR] Iniciado en {localAddr}:{port}. Esperando conexiones...");

            while (true)
            {
                // Espera asíncrona de un cliente
                TcpClient client = await server.AcceptTcpClientAsync();

                lock (lockObject)
                {
                    requestCounter++;
                    Console.WriteLine($"[SERVIDOR] Petición #{requestCounter} recibida.");
                }

                Conversor procesoConversion = new Conversor(client);
                // Dispara y olvida la tarea asíncrona para no bloquear el bucle
                _ = procesoConversion.ProcessRequestAsync();
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine($"SocketException: {e}");
        }
    }
}