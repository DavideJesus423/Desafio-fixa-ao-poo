using System;

class Program
{
    static void Main()
    {
        ContaBancariaPoli c1 = new ContaCorrente(100, 50);
        ContaBancariaPoli c2 = new ContaInvestimento(200);
        c1.Sacar(120);
        c2.Sacar(50);
    }
}

abstract class ContaBancariaPoli
{
    public double Saldo;
    public ContaBancariaPoli(double s) { Saldo = s; }
    public abstract void Sacar(double v);
}
class ContaCorrente : ContaBancariaPoli
{
    public double Limite;
    public ContaCorrente(double s, double l) : base(s) { Limite = l; }
    public override void Sacar(double v)
    {
        if (v <= Saldo + Limite) { Saldo -= v; Console.WriteLine("Q49: Saque conta corrente OK"); }
        else Console.WriteLine("Q49: Limite insuficiente!");
    }
}
class ContaInvestimento : ContaBancariaPoli
{
    public ContaInvestimento(double s) : base(s) { }
    public override void Sacar(double v)
    {
        if (v <= Saldo) { Saldo -= v; Console.WriteLine("Q49: Saque investimento OK (c/ rendimento)"); }
        else Console.WriteLine("Q49: Saldo insuficiente!");
    }
}
