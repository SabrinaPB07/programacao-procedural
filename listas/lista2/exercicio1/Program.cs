using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("digite o seu nome de usuario");
      string usuario = Console.ReadLine();

     Console.WriteLine("insira a sua senha:");
     string senha = Console.ReadLine();

      if (usuario == "admin" && senha == "123senha")
      {
        Console.WriteLine("Login realizado com sucesso!");
      }
      else 
      {
        Console.WriteLine("credenciais invalidas...");
      }

    }
}
