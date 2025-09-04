using System;

class Program
{
    static void Main()
    {
        Triangulo t = new Triangulo(3, 4, 5);
        Console.WriteLine($"Q15: Perímetro = {t.Perimetro()}");
    }
}

class Triangulo
{
    public double L1, L2, L3;
    public Triangulo(double a, double b, double c) { L1 = a; L2 = b; L3 = c; }
    public double Perimetro() => L1 + L2 + L3;
}
