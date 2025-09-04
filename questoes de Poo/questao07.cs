using System;

class Program
{
    static void Main()
    {
        Circulo c = new Circulo { Raio = 3 };
        Console.WriteLine($"Q7: Área={c.Area():F2}, Perímetro={c.Perimetro():F2}");
    }
}

class Circulo
{
    public double Raio;
    public double Area() => Math.PI * Raio * Raio;
    public double Perimetro() => 2 * Math.PI * Raio;
}
