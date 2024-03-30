using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_MATRIZ = 3;
        int somatorio = 0;

        int[,] matriz = new int[NUMERO_MATRIZ, NUMERO_MATRIZ];

        for (int linha = 0; linha < NUMERO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < NUMERO_MATRIZ; coluna++)
            {
                System.Console.WriteLine("digite um numero:");
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }

        for (int linha = 0; linha < NUMERO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < NUMERO_MATRIZ; coluna++)
            {
                if (linha == coluna)
                {
                    somatorio = somatorio + matriz[linha, coluna];
                }
            }
        }
        System.Console.WriteLine(somatorio);

    }
}
