using System;

class Program
{
    static void Main()
    {
        QuadradoHer q = new QuadradoHer(4);
        Console.WriteLine($"Q33: Área = {q.Area()}");
    }
}

class FormaBase
{
    public virtual double Area() => 0;
}
class QuadradoHer : FormaBase
{
    public double Lado;
    public QuadradoHer(double l) { Lado = l; }
    public override double Area() => Lado * Lado;
}
