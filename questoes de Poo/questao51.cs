using System;

class Program
{
    static void Main()
    {
        FormaAbs f1 = new TrianguloAbs(3, 4);
        FormaAbs f2 = new RetanguloAbs(5, 6);
        Console.WriteLine($"Q51: Triângulo área = {f1.Area()}");
        Console.WriteLine($"Q51: Retângulo área = {f2.Area()}");
    }
}

abstract class FormaAbs { public abstract double Area(); }
class TrianguloAbs : FormaAbs
{
    double b, h;
    public TrianguloAbs(double b, double h) { this.b = b; this.h = h; }
    public override double Area() => (b * h) / 2;
}
class RetanguloAbs : FormaAbs
{
    double l, a;
    public RetanguloAbs(double l, double a) { this.l = l; this.a = a; }
    public override double Area() => l * a;
}
