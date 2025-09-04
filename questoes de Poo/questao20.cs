using System;

class Program
{
    static void Main()
    {
        Jogo j = new Jogo("FIFA", "PC");
        j.Jogar();
    }
}

class Jogo
{
    public string Nome, Plataforma;
    public Jogo(string n, string p) { Nome = n; Plataforma = p; }
    public void Jogar() => Console.WriteLine($"Q20: Jogando {Nome} no {Plataforma}!");
}
