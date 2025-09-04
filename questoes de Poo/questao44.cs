using System;

class Program
{
    static void Main()
    {
        VeiculoBasePoli b = new Bicicleta();
        VeiculoBasePoli m = new Moto();
        Console.WriteLine($"Q44: {b.Acelerar()}");
        Console.WriteLine($"Q44: {m.Acelerar()}");
    }
}

abstract class VeiculoBasePoli
{
    public abstract string Acelerar();
}
class Bicicleta : VeiculoBasePoli
{
    public override string Acelerar() => "Pedalando mais rápido!";
}
class Moto : VeiculoBasePoli
{
    public override string Acelerar() => "Acelerando com motor!";
}
