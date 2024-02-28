using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite a primeira nota:");
        double nota1 = double.Parse(Console.ReadLine());

         Console.WriteLine("digite a segunda nota:");
         double nota2 = double.Parse(Console.ReadLine());

          Console.WriteLine("digite a terceira nota:");
         double nota3 = double.Parse(Console.ReadLine());

          Console.WriteLine("digite a quarta nota:");
         double nota4 = double.Parse(Console.ReadLine());

         double notaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

         if (notaFinal >= 5.0)
         {
            Console.WriteLine("Aluno aprovado");
         }
         else if (notaFinal < 5.0 && notaFinal >= 3.0)
         {
            Console.WriteLine("aluno em recuperacao");
         }
        else
        {
            Console.WriteLine("Aluno reprovado");
        }

    }
}
