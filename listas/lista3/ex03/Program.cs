using System;

class Program
{
    static void Main(string[] args)
    {
        const string NOME_DE_USUARIO_CORRETO = "admin";
        const string SENHA_CORRETA =  "123senha";
        int contadortentativas = 1;
        const int NUMERO_MAXIMO_DE_TENTATIVAS = 3;

        do 
        {
            Console.WriteLine("\ndigite o seu nome de usuario:");
            string nomeDeUsuario = Console.ReadLine();
            Console.WriteLine("digite a sua senha:");
            string senhaDigitada = Console.ReadLine();

            if (nomeDeUsuario == NOME_DE_USUARIO_CORRETO && senhaDigitada == SENHA_CORRETA)
            {
                Console.WriteLine("Login realizado com sucesso");
                break;
            }
            contadortentativas++;
        } 
        while(contadortentativas <= NUMERO_MAXIMO_DE_TENTATIVAS);

        if (contadortentativas > NUMERO_MAXIMO_DE_TENTATIVAS)
        {
            Console.WriteLine("sua conta foi bloqueada");
        }
    }
}
