using System;

class Program
{
    static void Main()
    {
        Veiculo v = new Veiculo("Ford", "Fiesta");
        v.Acelerar();
    }
}

class Veiculo
{
    public string Marca, Modelo;
    public Veiculo(string m, string mo) { Marca = m; Modelo = mo; }
    public void Acelerar() => Console.WriteLine("Q14: Acelerando!");
}
