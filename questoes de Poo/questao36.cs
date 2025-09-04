using System;

class Program
{
    static void Main()
    {
        Gerente g = new Gerente(3000, 1000);
        Console.WriteLine($"Q36: Salário total = {g.CalcularSalarioTotal()}");
    }
}

class FuncionarioBase
{
    public double Salario;
    public FuncionarioBase(double s) { Salario = s; }
}
class Gerente : FuncionarioBase
{
    public double Bonus;
    public Gerente(double s, double b) : base(s) { Bonus = b; }
    public double CalcularSalarioTotal() => Salario + Bonus;
}
