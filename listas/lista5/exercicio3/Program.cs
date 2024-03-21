using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("digite a base do retangulo:");
        int baseRetangulo = int.Parse(Console.ReadLine());
        System.Console.WriteLine("digite a altura do triangulo:");
        int alturaRetangulo = int.Parse(Console.ReadLine());

        for (int coluna = 1; coluna <= baseRetangulo; coluna ++)
        {
            for (int linha = 1; linha <= alturaRetangulo; linha++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}
