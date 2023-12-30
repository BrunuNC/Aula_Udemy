namespace Condicional08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto;

            salario = double.Parse(Console.ReadLine());

            if (salario <= 2000.0)
            {
                Console.WriteLine("ISENTO");

            } else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine($"R$ {imposto:F2}");
                
            } else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine($"R$ {imposto:F2}");
                
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 018 + 1000.0 * 0.08;
                Console.WriteLine($"R$ {imposto:F2}");
            }
        }
    }
}
