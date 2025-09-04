using System;

class Program
{
    static void Main()
    {
        Empregado e = new Empregado(2000);
        Console.WriteLine($"Q29: Bônus = {e.CalcularBonus()}");
    }
}

class Empregado
{
    private double salario;
    public Empregado(double s) { salario = s; }
    public double CalcularBonus() => salario * 0.1;
}
