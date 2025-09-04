using System;

class Program
{
    static void Main()
    {
        AlunoHer a = new AlunoHer("Davi", 20, 9.5);
        a.Estudar();
    }
}

class PessoaBase
{
    public string Nome;
    public int Idade;
    public PessoaBase(string n, int i) { Nome = n; Idade = i; }
}
class AlunoHer : PessoaBase
{
    public double Nota;
    public AlunoHer(string n, int i, double no) : base(n, i) { Nota = no; }
    public void Estudar() => Console.WriteLine($"Q34: {Nome} está estudando.");
}
