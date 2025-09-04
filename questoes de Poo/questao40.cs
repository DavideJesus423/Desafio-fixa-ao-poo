using System;

class Program
{
    static void Main()
    {
        LivroHer l = new LivroHer("Biblia", "Deus");
        Revista r = new Revista("Ciência Hoje", "Edição 50");
        Console.WriteLine($"Q40: Livro = {l.Titulo}, Autor = {l.Autor}");
        Console.WriteLine($"Q40: Revista = {r.Titulo}, Edição = {r.Edicao}");
    }
}

class BibliotecaItem
{
    public string Titulo;
    public BibliotecaItem(string t) { Titulo = t; }
}
class LivroHer : BibliotecaItem
{
    public string Autor;
    public LivroHer(string t, string a) : base(t) { Autor = a; }
}
class Revista : BibliotecaItem
{
    public string Edicao;
    public Revista(string t, string e) : base(t) { Edicao = e; }
}
