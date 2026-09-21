namespace EjerciciosC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine($"Suma: 10 + 5 = {calc.Sumar(10, 5)}");
            Console.WriteLine($"Resta: 15 - 3 = {calc.Restar(15, 3)}");
            Console.WriteLine($"Multiplicación: 7 * 8 = {calc.Multiplicar(7, 8)}");
            Console.WriteLine($"División: 20 / 4 = {calc.Dividir(20, 4)}");

            Console.WriteLine("\n--- Operaciones con sobrecarga (tres operandos) ---");
            Console.WriteLine($"Suma: 5 + 10 + 15 = {calc.Sumar(5, 10, 15)}");
            Console.WriteLine($"Resta: 50 - 10 - 5 = {calc.Restar(50, 10, 5)}");
            Console.WriteLine($"Multiplicación: 2 * 3 * 4 = {calc.Multiplicar(2, 3, 4)}");
            Console.WriteLine($"División: 100 / 5 / 2 = {calc.Dividir(100, 5, 2)}");

            Console.WriteLine($"\nÚltimo resultado calculado: {calc.UltimoResultado}");
        }
    }
}
