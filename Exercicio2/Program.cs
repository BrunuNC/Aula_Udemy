using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio, pi;

            pi = 3.14159;

            Console.WriteLine("Digite o valor do Raio: ");
            raio = double.Parse(Console.ReadLine());

            area = pi * (raio * raio);

            Console.WriteLine($"AREA: {area:F4}");
            
            /*
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
            */
        }
    }
}
