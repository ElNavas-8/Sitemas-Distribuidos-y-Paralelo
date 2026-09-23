using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Empleado : Persona
    {   
        public int numeroEmpleado { get; set; }
        public Empleado(string elNombre, DateTime laFechaNacimiento, int elNumeroEmpleado) 
            : base(elNombre, laFechaNacimiento)
        {
            this.numeroEmpleado = elNumeroEmpleado;
        }

        public override void ComunicarIncidencia(string mensaje)
        {
            Console.WriteLine("El empleado {0} con número de empleado {1} tiene la incidencia: {2}", 
                this.Nombre, this.numeroEmpleado, mensaje);
        }
    }
}
