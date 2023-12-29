namespace Condicional03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');

            int n1 = int.Parse(num[0]);

            int n2 = int.Parse(num[1]);

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MUILTIPLOS");

            }
        }
    }
}
