using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 3;
        int[] vetor = new int[TAMANHO_VETOR];

        int maiorElemento = ReceberMaiornumero(vetor);

        System.Console.WriteLine(maiorElemento);
    }

    static int ReceberMaiornumero(int[] numeros)
    {
        const int TAMANHO_VETOR = 3;
        int maiorElemento = 0;

        for(int i = 0; i < TAMANHO_VETOR; i++)
        {
            System.Console.WriteLine("digite um numero;");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado > maiorElemento)
            {
                maiorElemento = numeroDigitado;
            }
        }

        return maiorElemento;
    }
}
