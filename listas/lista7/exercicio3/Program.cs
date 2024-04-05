using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("insira a idade do nadador para ver sua classficação:");
        int idadeNadador = Convert.ToInt32(Console.ReadLine());

        ClassificarNadador(idadeNadador);

    
    }

    static int ClassificarNadador(int idadeNadador)
    {

        const int IDADE_INFANTIL = 12;
        const int IDADE_JUVENIL_A = 14;
        const int IDADE_JUVENIL_B = 17;
        const int IDADE_ADULTO = 18;

        if (idadeNadador  < IDADE_INFANTIL)
        {
            System.Console.WriteLine("Infantil");
        }
        else if (idadeNadador >= IDADE_INFANTIL && idadeNadador <=IDADE_JUVENIL_A )
        {
            System.Console.WriteLine("Juvenil A");
        }
        else if (idadeNadador > IDADE_JUVENIL_A && idadeNadador <=IDADE_JUVENIL_B )
        {
            System.Console.WriteLine("Juvenil B");
        }
        else if (idadeNadador >= IDADE_ADULTO)
        {
            System.Console.WriteLine("adulto");
        }

        return idadeNadador;
    }

}
