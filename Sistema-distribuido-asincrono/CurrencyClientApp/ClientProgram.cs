using System;
using System.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class ClientProgram
{
    public static async Task Main(string[] args)
    {
        string host = ConfigurationManager.AppSettings["host"] ?? "127.0.0.1";
        int port = int.Parse(ConfigurationManager.AppSettings["port"] ?? "13000");

        Console.WriteLine("=== CLIENTE INTERACTIVO CONVERSOR DE DIVISAS ===");

        while (true)
        {
            Console.WriteLine("\n------------------------------------------------");
            Console.Write("Ingrese divisa de origen (ej. EUR, USD) o 'salir' para terminar: ");
            string? origen = Console.ReadLine()?.Trim();

            if (string.Equals(origen, "salir", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Console.Write("Ingrese divisa de destino (ej. USD, EUR): ");
            string? destino = Console.ReadLine()?.Trim();

            Console.Write("Ingrese la cantidad a convertir: ");
            string? cantidadStr = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino) || string.IsNullOrEmpty(cantidadStr))
            {
                Console.WriteLine("[ERROR] Datos incompletos. Intente de nuevo.");
                continue;
            }

            try
            {
                using (TcpClient client = new TcpClient())
                {
                    // Conexión asíncrona
                    await client.ConnectAsync(host, port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        string xmlRequest = $"<ConvertRequest><from>{origen}</from><to>{destino}</to><units>{cantidadStr}</units></ConvertRequest>";
                        byte[] data = Encoding.ASCII.GetBytes(xmlRequest);

                        // Envío del mensaje XML de forma asíncrona
                        await stream.WriteAsync(data, 0, data.Length);
                        Console.WriteLine("[CLIENTE] Petición enviada al servidor...");

                        // Recepción de la respuesta de forma asíncrona
                        byte[] responseBuffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
                        string responseData = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);

                        Console.WriteLine("[CLIENTE] Respuesta recibida del servidor:\n" + responseData);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CLIENTE] Error al comunicarse con el servidor: {ex.Message}");
            }
        }

        Console.WriteLine("\nAplicación cliente finalizada.");
    }
}