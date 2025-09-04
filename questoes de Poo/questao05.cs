using System;

class Program
{
    static void Main()
    {
        Quadrado q = new Quadrado { Lado = 4 };
        Console.WriteLine($"Q5: Área do quadrado = {q.Area()}");
    }
}

class Quadrado
{
    public double Lado;
    public double Area() => Lado * Lado;
}
