using System;

class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_NOMES = 10;

        string[] nomes = new string[QUANTIDADE_NOMES];

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            System.Console.WriteLine("digite um nome para ser armazenado:");
            nomes[contador] = Console.ReadLine();
        }

        System.Console.WriteLine("digite um nome para ser buscado:");
        string nomeInserido = Console.ReadLine();

        bool temNomeInserido = false;
        for (int contador = 0; contador < nomes.Length; contador++)
        {
           
            if (nomes[contador] == nomeInserido)
            {
                temNomeInserido = true;
                
            }
        }
    
        if (temNomeInserido)
        {
            
            System.Console.WriteLine("ACHEI");
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI");
        }

    }
}
