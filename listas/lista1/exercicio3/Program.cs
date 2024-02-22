using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("insira a quantidade de dinheiro em centavos para a conversão em reais:");
        int centavos = int.Parse(Console.ReadLine());

        int reais = centavos / 100;
        int resultado = centavos % 100;
         
         Console.WriteLine("O total em dinheiro eh: " + reais + " real(is) e " + resultado + " centavo(s)");


    }
}