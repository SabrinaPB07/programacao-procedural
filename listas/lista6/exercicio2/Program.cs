using System;

class Program
{
    static void Main(string[] args)
    {
        const int MAXIMO_NOMES = 10;
        string[] nomes = new string[MAXIMO_NOMES];

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            System.Console.WriteLine("digite um nome:");
            nomes[contador] = Console.ReadLine();
        }

        for (int contador = MAXIMO_NOMES -1; contador >= 0; contador--)
        {
            if (contador %2 == 0)
            {
                System.Console.WriteLine(nomes[contador]);
            }
        }
    }
}