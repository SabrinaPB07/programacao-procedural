using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite a base do triangulo: ");
        double baseDoTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("digite a altura do triangulo: ");
        double alturaDoTriangulo = double.Parse(Console.ReadLine());

      double AreaDoTriangulo = (baseDoTriangulo * alturaDoTriangulo) / 2;
      bool resultado = AreaDoTriangulo > 20;

      Console.WriteLine("A area do triangulo eh maior que 20? " + resultado);

    }
}
