using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Biblioteca b = new Biblioteca();
        b.AdicionarLivro("Clean Code");
        b.AdicionarLivro("POO Avançado");
        Console.WriteLine("Q17: Livros adicionados à biblioteca.");
    }
}

class Biblioteca
{
    private List<string> Livros = new List<string>();
    public void AdicionarLivro(string titulo) => Livros.Add(titulo);
}
