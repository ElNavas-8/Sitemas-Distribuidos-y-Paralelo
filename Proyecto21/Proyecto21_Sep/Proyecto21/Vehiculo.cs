using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Vehiculo
    {
        // Atributo
        private static int cantidadVehiculos = 0;
        private string marca;
        private int velocidad;

        // Propiedad
        public string Marca{
            get { return this.marca; }
            internal set { this.marca = value; }
        }

        public int Velocidad{
            get => velocidad;
        }
        public static int CantidadVehiculos { get => cantidadVehiculos;}

        public void Acelerar(int incremento){
            this.Acelerar(incremento, false);
        }

        public void Acelerar(int incremento, bool turbo){
            this.velocidad += incremento;
            if (turbo)
            {
                Console.WriteLine("Velocidad actual del vehiculo con turbo {0} a {1}km/h", this.marca, this.velocidad);
            }
            else
            {
                Console.WriteLine("Velocidad actual del vehiculo {0} a {1}km/h", this.marca, this.velocidad);
            }
        }

        // Setter
        /* public void ModificarMarca(Vehiculo vehiculo, string nuevaMarca){
            vehiculo.marca = nuevaMarca;
        }

        //Getter
        public string GetMarca(){
            return marca;
        } */

        // Constructor
        public Vehiculo():this("Sin marca"){
        }

        public Vehiculo(string marca){
            this.marca = marca;
            Vehiculo.cantidadVehiculos++;
        }
    }
}
