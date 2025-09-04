using System;

class Program
{
    static void Main()
    {
        ProdutoEnc p = new ProdutoEnc(100);
        p.AplicarDesconto(20);
        Console.WriteLine($"Q24: Preço final = {p.Preco}");
    }
}

class ProdutoEnc
{
    private double preco;
    public double Preco => preco;

    public ProdutoEnc(double valor) { preco = valor; }

    public void AplicarDesconto(double perc)
    {
        double desconto = preco * (perc / 100);
        if (preco - desconto >= 0) preco -= desconto;
    }
}
