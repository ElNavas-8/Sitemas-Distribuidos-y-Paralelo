using ConsoleApp1;
using ClassLibrary1;
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
            
            Class1 fileName = new Class1();
            Console.WriteLine(fileName.Description);

            Class2 class1 = new Class2();
            Console.WriteLine(class1.Description);

            Console.WriteLine("Hello, World!");
            String? input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}