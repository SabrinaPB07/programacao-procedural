using System;

class Program
{
    static void Main(string[] args)
    {

        const int MENOR_TAMANHO = 1;
        const int MAIOR_TAMANHO =9;

        for ( int contador = 1; contador == contador; contador++)
        {
            System.Console.WriteLine("digite a altura desejda do triangulo retangulo: ");
            int alturaDoTrianguloRetangulo = int.Parse(Console.ReadLine());

            if (alturaDoTrianguloRetangulo >= MENOR_TAMANHO && alturaDoTrianguloRetangulo <= MAIOR_TAMANHO)
            {
                for (int linha = 1; linha <= alturaDoTrianguloRetangulo; linha++)
                {
                    for ( int coluna = 1; coluna <= alturaDoTrianguloRetangulo; coluna++)
                    {
                        if (coluna <= linha)
                        {
                            Console.Write(coluna);
                        }
                    }
                    System.Console.WriteLine();
                }
                break;
            } 
            else
            {
                System.Console.WriteLine("altura invalida, digite uma altura de 1 a 9");
            }
        }
    }
}
