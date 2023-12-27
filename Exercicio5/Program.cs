using System.Globalization;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int p1, p2, qtd1, qtd2;
            float valor, valor2, total;

            Console.WriteLine("Código da peça 1");
            p1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Quantidade: ");
            qtd1 = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Valor: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Código da peça 2");
            p2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            qtd2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor: ");
            valor2 = float.Parse(Console.ReadLine());
            
            total = qtd1 * valor + qtd2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
            */
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
