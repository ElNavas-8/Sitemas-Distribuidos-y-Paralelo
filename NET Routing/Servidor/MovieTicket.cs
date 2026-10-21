using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace Servidor
{
    internal class MovieTicket :MarshalByRefObject, IMovieTicket
    {
        public static int numInstances = 0;

        public MovieTicket()
        {
            numInstances++;
        }
        public string GetTicketStatus(string stringToPrint)
        {
            string returnStatus = "ticket Confirmado";
            Console.WriteLine(stringToPrint);
            Console .WriteLine("Número de instancias de MovieTicket: " + numInstances);
            return returnStatus;
        }
    }
}
