using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Persona
    {
        // Encapsulamiento: Propiedad Nombre con getter y setter
        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public String? DNI { get; set; }

        // Ticks (Tiempo) que han pasado desde la fecha establecida hasta el momento actual
        public int Edad { get{
                return DateTime.Now.Year - FechaNacimiento.Year; 
            } 
        }
        public void OperacionescConFecha()
        {
            // DateTime.Now y DateTime.Today para obtener la fecha actual.
            // DateTime.Today devuelve la fecha actual sin la hora, mientras que DateTime.Now devuelve la fecha y hora actual.
            int numAños = this.FechaNacimiento.Subtract(DateTime.Today).Days / 365;
            Console.WriteLine("{0} tiene {1} años calculados por diferencia de fechas", this.Nombre, Math.Abs(numAños));
        }

        public virtual void ComunicarIncidencia(string mensaje)
        {
            Console.WriteLine("{0} tiene la incidencia: {1}", this.Nombre, mensaje);
        }

        public Persona(DateTime laFechaNacimiento) : this("Sin nombre", laFechaNacimiento)
        {
        }

        public Persona(string elNombre, DateTime laFechaNacimiento)
        {
            this.Nombre = elNombre;
            this.FechaNacimiento = laFechaNacimiento;
        }

        public override string ToString()
        {
            return $"{this.Nombre}, ({this.FechaNacimiento.ToShortDateString()})";
        }

    }
}
