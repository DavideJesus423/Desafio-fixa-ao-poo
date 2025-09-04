using System;

class Program
{
    static void Main()
    {
        Usuario u = new Usuario("Ana", "ana@email.com");
        u.AlterarEmail("nova@email.com");
        Console.WriteLine($"Q16: {u.Nome} - {u.Email}");
    }
}

class Usuario
{
    public string Nome, Email;
    public Usuario(string n, string e) { Nome = n; Email = e; }
    public void AlterarEmail(string novo) => Email = novo;
}
