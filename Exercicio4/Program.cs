namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario;
            float horas, valorHora, salario;

            Console.WriteLine("Nº do Funcionario: ");
            nFuncionario = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Horas trabalhadas: ");
            horas = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Valor da Hora: ");
            valorHora = float.Parse(Console.ReadLine()!);

            salario = valorHora * horas;

            Console.WriteLine($"NUMERO = {nFuncionario}");
            Console.WriteLine($"SALARIO = R$ {salario:F2}");

        }
    }
}
