using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;

        do
        {
            System.Console.WriteLine("digite um numero: ");
            int numeroRecebido = int.Parse(Console.ReadLine());

            if (numeroRecebido %2 == 1)
            {
                somatorio = somatorio + numeroRecebido;
            }
            else if (numeroRecebido < 0 )
            {
                break;
            }
        } while (true);
        System.Console.WriteLine("O somatorio dos impares eh: " + somatorio);
    }
}
