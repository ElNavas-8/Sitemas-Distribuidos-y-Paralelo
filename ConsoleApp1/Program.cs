using ConsoleApp1;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            FileName fileName = new FileName();
            Console.WriteLine(fileName.Description);
            //Console.WriteLine("Hello, World!");
            //String? input = Console.ReadLine();
            //Console.WriteLine(input);
        }
    }
}