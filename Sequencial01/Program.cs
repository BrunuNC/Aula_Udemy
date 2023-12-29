namespace Sequencial01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

        }
    }
}
