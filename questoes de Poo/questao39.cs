using System;

class Program
{
    static void Main()
    {
        JogoOnline j = new JogoOnline("CS", "Servidor1");
        j.Conectar();
    }
}

class JogoBase
{
    public string Nome;
    public JogoBase(string n) { Nome = n; }
}
class JogoOnline : JogoBase
{
    public string Servidor;
    public JogoOnline(string n, string s) : base(n) { Servidor = s; }
    public void Conectar() => Console.WriteLine($"Q39: Conectando {Nome} no {Servidor}");
}
