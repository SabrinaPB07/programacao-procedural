using System;

class Program
{
    static void Main(string[] args)
    {
        for (int progressivo = 0, regressivo = 200; progressivo <= 100; progressivo += 2, regressivo -= 4)
        {
        
            System.Console.WriteLine($"{progressivo} - {regressivo}");
        }
    }
}
