namespace EjerciciosC_
{   
    public class Calculadora
    {
        private int ultimoResultado;

        public int UltimoResultado
        {
            get { return ultimoResultado; }
            set { ultimoResultado = value; }
        }

        public int Sumar(int a, int b)
        {
            return Sumar(a, b, 0);
        }

        public int Sumar(int a, int b, int c)
        {
            ultimoResultado = a + b + c;
            return ultimoResultado;
        }

        public int Restar(int a, int b)
        {
            return Restar(a, b, 0);
        }

        public int Restar(int a, int b, int c)
        {
            ultimoResultado = a - b - c;
            return ultimoResultado;
        }

        public int Multiplicar(int a, int b)
        {
            return Multiplicar(a, b, 1);
        }

        public int Multiplicar(int a, int b, int c)
        {
            ultimoResultado = a * b * c;
            return ultimoResultado;
        }

        public int Dividir(int a, int b)
        {
            return Dividir(a, b, 1);
        }

        public int Dividir(int a, int b, int c)
        {
            if (b == 0 || c == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
                return 0;
            }
            ultimoResultado = a / b / c;
            return ultimoResultado;
        }
    }
}