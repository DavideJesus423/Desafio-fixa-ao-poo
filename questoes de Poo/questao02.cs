using System;

class Program
{
    static void Main()
    {
        Carro c = new Carro();
        Console.WriteLine($"Q2: Cor do carro = {c.Cor}");
    }
}

class Carro
{
    public string Cor = "Vermelho";
}
