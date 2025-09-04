using System;

class Program
{
    static void Main()
    {
        Forma f = new Forma(25);
        Console.WriteLine($"Q28: Área = {f.Area}");
    }
}

class Forma
{
    private double area;
    public double Area => area;

    public Forma(double a) { area = a; }
}
