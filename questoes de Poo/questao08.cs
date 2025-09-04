using System;

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(100);
        Console.WriteLine($"Q8: Saldo = {conta.Saldo}");
    }
}

class ContaBancaria
{
    public double Saldo = 0;
    public void Depositar(double v) { Saldo += v; }
}
