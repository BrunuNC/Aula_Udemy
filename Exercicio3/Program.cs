namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;

            Console.WriteLine("Digite o primeiro valor: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor: ");
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B - C * D);

            Console.WriteLine($"DIFERENÇA = {diferenca}");
        }
    }
}
