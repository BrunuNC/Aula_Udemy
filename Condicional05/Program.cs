using System.Globalization;

namespace Condicional05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("CODIGO\t\tESPECIFICAÇÃO\t\tPREÇO");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1\t\tCachorro Quente\t\tR$ 4.00");
            Console.WriteLine("2\t\tX-Salada\t\tR$ 4.50");
            Console.WriteLine("3\t\tX-Bacon\t\t\tR$ 5.00");
            Console.WriteLine("4\t\tTorrada Simples\t\tR$ 2.00");
            Console.WriteLine("5\t\tRefrigerante\t\tR$ 1.50");
            Console.WriteLine("---------------------------------------------------");

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
