using System;

class Program
{
    static void Main()
    {
        ProdutoPoli f = new ProdutoFisico(100, 20);
        ProdutoPoli s = new ProdutoServico(200, 15);
        Console.WriteLine($"Q46: Preço físico = {f.CalcularPreco()}");
        Console.WriteLine($"Q46: Preço serviço = {s.CalcularPreco()}");
    }
}

abstract class ProdutoPoli
{
    public abstract double CalcularPreco();
}
class ProdutoFisico : ProdutoPoli
{
    double preco, frete;
    public ProdutoFisico(double p, double f) { preco = p; frete = f; }
    public override double CalcularPreco() => preco + frete;
}
class ProdutoServico : ProdutoPoli
{
    double preco, taxa;
    public ProdutoServico(double p, double t) { preco = p; taxa = t; }
    public override double CalcularPreco() => preco + taxa;
}
