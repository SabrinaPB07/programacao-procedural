using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;

        Produto[] produtos = new Produto[TAMANHO_VETOR];

        for (int i = 0; i < produtos.Length; i++)
        {
            System.Console.WriteLine("digite o id do produto:");
            produtos[i].id = int.Parse(Console.ReadLine());

            System.Console.WriteLine("digite o nome do produto");
            produtos[i].nome = Console.ReadLine();

            System.Console.WriteLine("digite o preço do produto:");
            produtos[i].preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("o produto está em estoque?");
            produtos[i].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }

        for (int i = 0; i < produtos.Length; i++)
        {
            if ( produtos[i].disponivelEmEstoque)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine(produtos[i].preco);
            }
        }
    }
}
