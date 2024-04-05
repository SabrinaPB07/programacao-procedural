using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencherMatriz(matriz);

        bool resultado = PercorrerMatriz(matriz);

        if(resultado == true)
        {
            System.Console.WriteLine("fique atento! existem balistas no tabuleiro");
        }
        else
        {
            System.Console.WriteLine("nao ha balistas no tabuleiro");
        }
        
    }

    static void PreencherMatriz(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                System.Console.WriteLine("digite um numero: ");
                matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
            }
        }   
    }   

    static bool PercorrerMatriz(int[,] matriz)
    {
        bool existeBalista = false;
       for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {  
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                if (matriz[linha, coluna] == 0)
                {
                    existeBalista = true;
                }
            }
        }   
        return existeBalista;
    }
}