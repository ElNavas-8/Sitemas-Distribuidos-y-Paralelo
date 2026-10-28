using System.Diagnostics;

namespace Desayuno
{
    internal class Program
    {
        private static bool done = true;
        static void Main(string[] args)
        {
            bool salir = false;
            while (salir == false) {
                done = false;
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Elige como quiere hacer el desyuno");
                Console.WriteLine("    - 1. Hacer el desayuno de forma síncrona");
                Console.WriteLine("    - 2. Hacer el desayuno de forma asíncrona");
                Console.WriteLine("    - 3. Hacer el desayuno de forma asíncrona organizada");
                char LaOpcion = Console.ReadKey().KeyChar;
                switch (LaOpcion) { 
                case '1':
                    HacerDesayunoSincrono();
                    break;
                case '2':
                    HacerDesayunoAsincrono();
                    break;
                case '3':
                    HacerDesayunoAsincronoOrganizado();
                    break;
                }
                while (done == false || salir) { 
                    Console.WriteLine("---------- El cocinero silba ({0}) ---------", 
                        DateTime.Now.ToLongTimeString());
                    Thread.Sleep(1000);
                }
            }           
        }
        private static void HacerDesayunoSincrono()
        {
            Stopwatch conometro = Stopwatch.StartNew();

            TazaCafe cafe = PrepararCafe();
            ZumoNaranja zumo = PrepararZumo();
            Huevos huevos = PrepararHuevos();
            Tostadas tostadas = PrepararTostadas();
            tostadas = UntarMantequilla(tostadas);
            Bacon bacon = PrepararBacon();

            conometro.Stop();
            Console.WriteLine($"Desayuno preparado en {conometro.ElapsedMilliseconds/1000} s");
            
            done = true;
        }

        private static async void  HacerDesayunoAsincrono()
        {
            Stopwatch conometro = Stopwatch.StartNew();

            TazaCafe cafe =  await PrepararCafeAsync();
            ZumoNaranja zumo = await PrepararZumoAsync();
            Huevos huevos = await PrepararHuevosAsync();
            Tostadas tostadas = await PrepararTostadasAsync();
            tostadas = await UntarMantequillaAsync(tostadas);
            Bacon bacon = await PrepararBaconAsync();

            conometro.Stop();
            Console.WriteLine($"Desayuno preparado en {conometro.ElapsedMilliseconds / 1000} s");

            done = true;
        }

        private static async void HacerDesayunoAsincronoOrganizado()
        {
            Stopwatch conometro = Stopwatch.StartNew();

            Task<TazaCafe> cafeTask = PrepararCafeAsync();
            Task<ZumoNaranja> zumoTask = PrepararZumoAsync();
            Task<Huevos> huevosTask = PrepararHuevosAsync();
            Task<Tostadas> tostadasTask = PrepararTostadasAsync();
            Task<Bacon> baconTask = PrepararBaconAsync();

            await Task.WhenAll(
                cafeTask,
                zumoTask,
                huevosTask,
                tostadasTask,
                baconTask);

            TazaCafe cafe = await cafeTask;
            ZumoNaranja zumo = await zumoTask;
            Huevos huevos = await huevosTask;
            Tostadas tostadas = await tostadasTask;
            Bacon bacon = await baconTask;

            tostadas = await UntarMantequillaAsync(tostadas);

            conometro.Stop();
            Console.WriteLine(
                $"Desayuno preparado en {conometro.ElapsedMilliseconds / 1000} s");

            done = true;
        }
        #region Preparar Cafe
        private static TazaCafe PrepararCafe()
        {
            Console.WriteLine("Preparando cafe...");
            Thread.Sleep(1000);
            Console.WriteLine("Cafe preparado");
            return new TazaCafe();
        }
        private static async Task<TazaCafe> PrepararCafeAsync()
        {
            Console.WriteLine("Preparando cafe...");
            await Task.Delay(1000);
            Console.WriteLine("Cafe preparado");
            return new TazaCafe();
        }
        #endregion

        #region Preparar Zumo
        private static ZumoNaranja PrepararZumo()
        {
            Console.WriteLine("Preparando zumo...");
            Thread.Sleep(1000);
            Console.WriteLine("Zumo preparado");
            return new ZumoNaranja();
        }

        private static async Task<ZumoNaranja> PrepararZumoAsync()
        {
            Console.WriteLine("Preparando zumo...");
            await Task.Delay(1000);
            Console.WriteLine("Zumo preparado");
            return new ZumoNaranja();
        }
        #endregion

        #region Preparar Huevos
        private static Huevos PrepararHuevos()
        {
            Console.WriteLine("Preparando huevos...");
            Thread.Sleep(1000);
            Console.WriteLine("Huevos preparados");
            return new Huevos();
        }

        private static async Task<Huevos> PrepararHuevosAsync()
        {
            Console.WriteLine("Preparando huevos...");
            await Task.Delay(1000);
            Console.WriteLine("Huevos preparados");
            return new Huevos();
        }

        #endregion

        #region Preparar Tostadas
        private static Tostadas PrepararTostadas()
        {
            Console.WriteLine("Preparando tostadas...");
            Thread.Sleep(2000);
            Console.WriteLine("Tostadas preparadas");
            return new Tostadas();
        }

        private static Tostadas UntarMantequilla(Tostadas LasTostadas)
        {
            Console.WriteLine("Unto la mantequilla...");
            Thread.Sleep(2000);
            Console.WriteLine("Tostadas listas");
            return LasTostadas;
        }

        private static async Task<Tostadas> PrepararTostadasAsync()
        {
            Console.WriteLine("Preparando tostadas...");
            await Task.Delay(2000);
            Console.WriteLine("Tostadas preparadas");
            return new Tostadas();
        }

        private static async Task<Tostadas> UntarMantequillaAsync(Tostadas LasTostadas)
        {
            Console.WriteLine("Unto la mantequilla...");
            await Task.Delay(2000);
            Console.WriteLine("Tostadas listas");
            return LasTostadas;
        }
        #endregion

        #region Preparar Bacon
        private static Bacon PrepararBacon()
        {
            Console.WriteLine("Preparando bacon...");
            Thread.Sleep(2000);
            Console.WriteLine("Bacon preparado");
            return new Bacon();
        }

        private static async Task<Bacon> PrepararBaconAsync()
        {
            Console.WriteLine("Preparando bacon...");
            await Task.Delay(2000);
            Console.WriteLine("Bacon preparado");
            return new Bacon();
        }
        #endregion
    }
}