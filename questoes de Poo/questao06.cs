using System;

class Program
{
    static void Main()
    {
        Aluno a1 = new Aluno("João", 8.5);
        Aluno a2 = new Aluno("Maria", 7.9);
        string melhor = a1.Nota > a2.Nota ? a1.Nome : a2.Nome;
        Console.WriteLine($"Q6: Maior nota = {melhor}");
    }
}

class Aluno
{
    public string Nome;
    public double Nota;
    public Aluno(string n, double no)
    {
        Nome = n;
        Nota = no;
    }
}
