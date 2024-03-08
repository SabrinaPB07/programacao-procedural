using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_HABITANTES = 20;
        int somatorioDeFilhos = 0;
        double somatorioDosSalarios = 0;
        double maiorSalario = 0;
        


        for (int contador = 1; contador <= NUMERO_HABITANTES; contador++)
        {
            Console.WriteLine("digite o salario do " + contador + "º habitante: ");
            double salarioAtual = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade de filhos do " + contador + "º habitante:");
            int numeroDeFilhos = int.Parse(Console.ReadLine());

            somatorioDosSalarios = somatorioDosSalarios + salarioAtual;
            somatorioDeFilhos = somatorioDeFilhos + numeroDeFilhos;

            if (salarioAtual > maiorSalario)
            {
                maiorSalario = salarioAtual;
            }

        }

        somatorioDeFilhos = somatorioDeFilhos / NUMERO_HABITANTES;
        somatorioDosSalarios = somatorioDosSalarios / NUMERO_HABITANTES;

        System.Console.WriteLine(" a media salarial eh: R$" + Math.Round(somatorioDosSalarios, 2));
        System.Console.WriteLine("a media de filhos por habitante eh:" + somatorioDeFilhos);
        System.Console.WriteLine("o maior salario eh: R$" + maiorSalario);

    }
}
