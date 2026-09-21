namespace Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehiculo miVehiculo = new Vehiculo();
            Vehiculo miVehiculo2 = new Vehiculo();

            miVehiculo2.ModificarMarca(miVehiculo2, "Renault");

            // String concatenada
            Console.WriteLine("Mi auto es de marca " + miVehiculo.GetMarca());

            // String con punteros
            Console.WriteLine("Mi carrito es de marca {0}",miVehiculo2.GetMarca());
        }
    }
}
