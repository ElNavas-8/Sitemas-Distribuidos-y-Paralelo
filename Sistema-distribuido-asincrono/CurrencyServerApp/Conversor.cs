using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class Conversor
{
    private TcpClient client;

    public Conversor(TcpClient client)
    {
        this.client = client;
    }

    public async Task ProcessRequestAsync()
    {
        try
        {
            byte[] bytes = new byte[1024];
            NetworkStream stream = client.GetStream();

            // Lectura asíncrona
            int bytesRead = await stream.ReadAsync(bytes, 0, bytes.Length);
            string data = Encoding.ASCII.GetString(bytes, 0, bytesRead).Trim();

            decimal cantidad;
            string operacion = XmlConverter.ProcesarXmlConvertRequest(data, out cantidad);

            string responseXml;
            if (operacion == "EUR-USD")
            {
                decimal resultado = cantidad * 1.08m;
                responseXml = XmlConverter.GenerarPaqueteXmlConvertResponse("USD", resultado.ToString());
            }
            else if (operacion == "USD-EUR")
            {
                decimal resultado = cantidad * 0.92m;
                responseXml = XmlConverter.GenerarPaqueteXmlConvertResponse("EUR", resultado.ToString());
            }
            else
            {
                responseXml = XmlConverter.GenerarPaqueteXmlConvertResponseError("ERROR: Divisa no reconocida " + operacion);
            }

            byte[] msg = Encoding.ASCII.GetBytes(responseXml);
            // Escritura asíncrona
            await stream.WriteAsync(msg, 0, msg.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error en procesamiento de hilo: " + ex.Message);
        }
        finally
        {
            client.Close();
        }
    }
}