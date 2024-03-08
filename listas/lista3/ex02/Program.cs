using System;

class Program
{
    static void Main(string[] args)
    {
        const double VALOR_FRETE_GRATIS = 150.00;
        double valorTotaDosItens = 0;   
        double  precoDosItens = 0;

        int contador = 1;

        System.Console.WriteLine("Quantos itens voce comprou na loja?");
        int quantidadeDeitens = int.Parse(Console.ReadLine());

        while ( contador <= quantidadeDeitens)
        {
            System.Console.WriteLine("qual o preco do " + contador + "º item?");
            precoDosItens = double.Parse(Console.ReadLine());
            valorTotaDosItens = valorTotaDosItens + precoDosItens;
           contador++;
        }
        
        if (valorTotaDosItens >= VALOR_FRETE_GRATIS)
        {
            System.Console.WriteLine("Parabens! voce ganhou frete gratis em sua compra de valor " 
            + Math.Round(valorTotaDosItens, 2));
        }
        else
        {
            System.Console.WriteLine("A compra nao possui frete gratis");
        }
    }
} 
