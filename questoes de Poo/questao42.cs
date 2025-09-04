using System;

class Program
{
    static void Main()
    {
        EmpregadoBase h = new Horista(40, 20);
        EmpregadoBase a = new Assalariado(3000);
        Console.WriteLine($"Q42: Horista = {h.CalcularSalario()}");
        Console.WriteLine($"Q42: Assalariado = {a.CalcularSalario()}");
    }
}

abstract class EmpregadoBase
{
    public abstract double CalcularSalario();
}
class Horista : EmpregadoBase
{
    public int Horas;
    public double Taxa;
    public Horista(int h, double t) { Horas = h; Taxa = t; }
    public override double CalcularSalario() => Horas * Taxa;
}
class Assalariado : EmpregadoBase
{
    public double Salario;
    public Assalariado(double s) { Salario = s; }
    public override double CalcularSalario() => Salario;
}
