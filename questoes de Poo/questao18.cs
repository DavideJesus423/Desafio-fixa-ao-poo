using System;

class Program
{
    static void Main()
    {
        Calculadora c = new Calculadora();
        Console.WriteLine($"Q18: 5 + 3 = {c.Somar(5, 3)}");
        Console.WriteLine($"Q18: 5 - 3 = {c.Subtrair(5, 3)}");
        Console.WriteLine($"Q18: 5 * 3 = {c.Multiplicar(5, 3)}");
        Console.WriteLine($"Q18: 6 / 3 = {c.Dividir(6, 3)}");
    }
}

class Calculadora
{
    public double Somar(double a, double b) => a + b;
    public double Subtrair(double a, double b) => a - b;
    public double Multiplicar(double a, double b) => a * b;
    public double Dividir(double a, double b) => b != 0 ? a / b : double.NaN;
}
