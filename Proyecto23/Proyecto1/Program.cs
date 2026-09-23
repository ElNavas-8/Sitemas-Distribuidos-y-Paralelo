using ProyectoHerencia;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Persona persona1 = new Persona("Juan", new DateTime(2000, 12, 6));
            persona1.ComunicarIncidencia("He perdido el DNI");
            
            Persona empleado1 = new Empleado("Pedro", new DateTime(1995, 5, 15), 67);
            empleado1.ComunicarIncidencia("No hay papel en la impresora");

            Empleado empleado1_2 = (Empleado)empleado1;
            Console.WriteLine(empleado1_2.numeroEmpleado);

            Console.WriteLine("GetType: " + empleado1.GetType());
            Console.WriteLine("ToString: " + empleado1_2.ToString());
        }
    }
}
