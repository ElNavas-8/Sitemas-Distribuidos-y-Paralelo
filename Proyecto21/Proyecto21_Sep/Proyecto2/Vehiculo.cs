using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Vehiculo
    {
        public string Marca = "Seat";

        public void ModificarMarca(Vehiculo vehiculo, string nuevaMarca)
        {
            vehiculo.Marca = nuevaMarca;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public Vehiculo() {
            
        }
    }
}
