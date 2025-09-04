using System;

class Program
{
    static void Main()
    {
        CarroHer c = new CarroHer();
        Console.WriteLine($"Q32: Velocidade = {c.Velocidade}");
        c.Buzinar();
    }
}

class VeiculoBase
{
    public int Velocidade = 60;
}
class CarroHer : VeiculoBase
{
    public void Buzinar() => Console.WriteLine("Q32: Buzinando!");
}
