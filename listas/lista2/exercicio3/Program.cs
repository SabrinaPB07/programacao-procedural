using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite o nome da criança");
        string crianca = Console.ReadLine();

        if (crianca == "filomena")
        {
           Console.WriteLine("Rotina de filomena");
           Console.WriteLine("1. Escola das 07h as 12h");
           Console.WriteLine("2. Almoço das 12h as 13");
           Console.WriteLine("3. Futebol das 14h as 16h");
           Console.WriteLine("4. Dever de casa das 16h as 18h");
        }
        else if ( crianca == "joselito")
        {
            Console.WriteLine("1. Escola das 07h as 12:30");
            Console.WriteLine("2. Almoço das 13h as 14h");
            Console.WriteLine("3. Natação das 14h as 16h");
            Console.WriteLine("4. Reforço escolar das 16h as 19h");
        }
        else 
        {
            Console.WriteLine("crianca nao encontrada");
        }
    }
}