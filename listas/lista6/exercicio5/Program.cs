using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;
        const int TAMANHO_MINIMO = 10;
        const int TAMANHO_MAXIMO = 50;
        int contador = 0;

        int[] vetor = new int[TAMANHO_VETOR];

            while (contador < TAMANHO_VETOR)
            {
                System.Console.WriteLine("digite um numero:");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= TAMANHO_MINIMO && numero <= TAMANHO_MAXIMO)
                {
                    vetor[contador] = numero;
                    contador++;
                }
            }

        for (contador = 0; contador < TAMANHO_VETOR; contador++)
        {
            System.Console.WriteLine(vetor[contador]);
        }
    }
}
