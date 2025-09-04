using System;

class Program
{
    static void Main()
    {
        ContaPoupanca cp = new ContaPoupanca(100);
        cp.RenderJuros();
        Console.WriteLine($"Q35: Saldo = {cp.Saldo}");
    }
}

class ContaBase
{
    public double Saldo;
    public ContaBase(double s) { Saldo = s; }
}
class ContaPoupanca : ContaBase
{
    public ContaPoupanca(double s) : base(s) { }
    public void RenderJuros() => Saldo += Saldo * 0.01;
}
