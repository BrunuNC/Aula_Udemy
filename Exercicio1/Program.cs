class Somador
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro Número");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo Número");
        int n2 = int.Parse(Console.ReadLine());

        int soma = n1 + n2;

        Console.WriteLine($"SOMA: {soma}");
    }
}

/*
﻿using System;

namespace uri1003
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}*/