using System;

class Program
{
    static void Main()
    {
        Retangulo r = new Retangulo(5, 3);
        Console.WriteLine($"Q11: Área do retângulo = {r.Area()}");
    }
}

class Retangulo
{
    public double Largura, Altura;
    public Retangulo(double l, double a) { Largura = l; Altura = a; }
    public double Area() => Largura * Altura;
}
