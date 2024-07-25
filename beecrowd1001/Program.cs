using System;

class Program
{
    static void Main(string[] args)
    {
        int x;
        int y;
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("digite um numero inteiro");
        }
        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("digite um numero inteiro");
        }
        int soma = x + y;
        Console.WriteLine($"X = {soma}");

    }
}