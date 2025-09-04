using System;

class Program
{
    static void Main()
    {
        FuncionarioAbs f1 = new Vendedor(10000);
        FuncionarioAbs f2 = new Engenheiro(5000);
        Console.WriteLine($"Q54: Bônus vendedor = {f1.CalcularBonus()}");
        Console.WriteLine($"Q54: Bônus engenheiro = {f2.CalcularBonus()}");
    }
}

abstract class FuncionarioAbs { public abstract double CalcularBonus(); }
class Vendedor : FuncionarioAbs
{
    double vendas;
    public Vendedor(double v) { vendas = v; }
    public override double CalcularBonus() => vendas * 0.1;
}
class Engenheiro : FuncionarioAbs
{
    double salario;
    public Engenheiro(double s) { salario = s; }
    public override double CalcularBonus() => 1000; // fixo
}
