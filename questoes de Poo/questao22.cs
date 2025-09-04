using System;

class Program
{
    static void Main()
    {
        Conta c = new Conta();
        c.Depositar(100);
        c.Sacar(30);
        Console.WriteLine($"Q22: Saldo = {c.Saldo}");
    }
}

class Conta
{
    private double saldo = 0;
    public double Saldo => saldo;

    public void Depositar(double v) => saldo += v;

    public void Sacar(double v)
    {
        if (v <= saldo) saldo -= v;
        else Console.WriteLine("Q22: Saldo insuficiente!");
    }
}
