using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("digite um numero:");
        int valor = Convert.ToInt32(Console.ReadLine());

        bool retorno = Ehpar(valor);
        
        System.Console.WriteLine(retorno);
    }
    static bool Ehpar(int par)
    {
        return par %2 == 0;
    }
}
