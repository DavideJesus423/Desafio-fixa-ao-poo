using System;

class Program
{
    static void Main()
    {
        Ponto p = new Ponto { X = 3, Y = 4 };
        Console.WriteLine($"Q10: Distância até a origem = {p.DistanciaOrigem()}");
    }
}

class Ponto
{
    public double X;
    public double Y;
    public double DistanciaOrigem() => Math.Sqrt(X * X + Y * Y);
}
