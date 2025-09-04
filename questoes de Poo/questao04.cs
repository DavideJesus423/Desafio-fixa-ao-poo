using System;

class Program
{
    static void Main()
    {
        Livro l = new Livro { Titulo = "POO 101", Autor = "Ana" };
        l.ExibirInfo();
    }
}

class Livro
{
    public string Titulo;
    public string Autor;
    public void ExibirInfo() => Console.WriteLine($"Q4: {Titulo} - {Autor}");
}
