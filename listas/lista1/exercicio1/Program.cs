using System;
 
 class Program
 {
    static void Main(string[] args) 
    {

Console.WriteLine("digite a sua primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("digite a sua segunda nota:");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("digite a sua segunda nota: ");
double nota3 =  double.Parse(Console.ReadLine());

Console.WriteLine("digite a sua quarta nota:");
double nota4 = double.Parse(Console.ReadLine());

double mediaDoAluno = (nota1 + nota2 + nota3 + nota4) / 4.0;

Console.WriteLine("A média do aluno eh: " + mediaDoAluno);

    }
 }