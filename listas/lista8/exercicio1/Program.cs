using System;

struct Pizza
{
    public int id;
    public string sabor;
    public double preco;
}
class Program
{
    static void Main(string[] args)
    {
        Pizza pizzaDigitada;
        System.Console.WriteLine("digite o id da pizza:");
        pizzaDigitada.id = int.Parse(Console.ReadLine());

        System.Console.WriteLine("digite o sabor da pizza");
        pizzaDigitada.sabor = Console.ReadLine();

        System.Console.WriteLine("digite o preço da pizza: ");
        pizzaDigitada.preco = double.Parse(Console.ReadLine());

        System.Console.WriteLine(pizzaDigitada.id);
        System.Console.WriteLine(pizzaDigitada.sabor);
        System.Console.WriteLine(pizzaDigitada.preco);


    }
}
