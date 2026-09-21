namespace Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tengo muchos vehiculos");
            Vehiculo miVehiculo = new Vehiculo("BMW");
            // Vehiculo miVehiculo2 = new Vehiculo();

            Console.WriteLine("Velocidad inicial del vehiculo 1: {0}", miVehiculo.Velocidad);
            miVehiculo.Acelerar(20, false);
            Console.WriteLine("Velocidad actual del vehiculo 1 depues de acelerar: {0}", miVehiculo.Velocidad);
            miVehiculo.Acelerar(30, true);

            Vehiculo miVehiculo2 = new Vehiculo();

            Console.WriteLine("Cantidad de vehiculos: {0}", Vehiculo.CantidadVehiculos);

            // miVehiculo2.Marca = "Renault";
            //miVehiculo2.ModificarMarca(miVehiculo2, "Renault");

            // String concatenada
            //Console.WriteLine("Mi auto es de marca " + miVehiculo.Marca);

            // String con punteros
            //Console.WriteLine("Mi carrito es de marca {0}",miVehiculo2.Marca);
        }
    }
}
