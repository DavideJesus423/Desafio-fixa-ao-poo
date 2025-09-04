using System;

class Program
{
    static void Main()
    {
        Produto p = new Produto { Nome = "Caneta", Preco = 10 };
        p.AplicarDesconto();
        Console.WriteLine($"Q9: {p.Nome} - Preço c/ desconto = {p.Preco:F2}");
    }
}

class Produto
{
    public string Nome;
    public double Preco;
    public void AplicarDesconto() => Preco *= 0.9;
}
