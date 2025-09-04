using System;

class Program
{
    static void Main()
    {
        ProdutoDigital pd = new ProdutoDigital(50, 200);
        Console.WriteLine($"Q37: Tamanho = {pd.TamanhoArquivo}MB");
        pd.Baixar();
    }
}

class ProdutoBase
{
    public double Preco;
    public ProdutoBase(double p) { Preco = p; }
}
class ProdutoDigital : ProdutoBase
{
    public int TamanhoArquivo;
    public ProdutoDigital(double p, int t) : base(p) { TamanhoArquivo = t; }
    public void Baixar() => Console.WriteLine("Q37: Baixando produto digital...");
}
