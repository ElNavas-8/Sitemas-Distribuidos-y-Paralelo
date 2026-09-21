using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Vehiculo
    {
        // Atributo o Variable de instancia
        public string Marca = "Seat";

        // Setter
        public void ModificarMarca(Vehiculo vehiculo, string nuevaMarca)
        {
            vehiculo.Marca = nuevaMarca;
        }

        //Getter
        public string GetMarca()
        {
            return Marca;
        }

        // Constructor
        public Vehiculo() {
            this.Marca = "Seat";
        }
    }
}
