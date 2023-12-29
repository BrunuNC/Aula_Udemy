using System.Globalization;

namespace Condicional06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0.0 && valor < 25.0)
            {
                Console.WriteLine("INTERVALO [0,25]");
            }
            else if (valor >= 25.0 && valor < 50.0)
            {
                Console.WriteLine("INTERVALO [25,50]");
            }
            else if (valor >= 50.0 && valor < 75.0)
            {
                Console.WriteLine("INTERVALO [50,75]");
            }
            else if (valor >= 75.0 && valor <= 100.0)
            {
                Console.WriteLine("INTERVALO [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            */

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
