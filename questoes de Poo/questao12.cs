using System;

class Program
{
    static void Main()
    {
        Funcionario f = new Funcionario("Carlos", 2000);
        f.AumentarSalario(10);
        Console.WriteLine($"Q12: {f.Nome} - Salário = {f.Salario}");
    }
}

class Funcionario
{
    public string Nome;
    public double Salario;
    public Funcionario(string n, double s) { Nome = n; Salario = s; }
    public void AumentarSalario(double p) => Salario += Salario * (p / 100);
}
