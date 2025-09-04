using System;

class Program
{
    static void Main()
    {
        Arquivo a1 = new ArquivoTexto("dados.txt");
        Arquivo a2 = new ArquivoBinario("dados.bin");
        a1.Abrir();
        a2.Abrir();
    }
}

abstract class Arquivo
{
    public string Nome;
    public Arquivo(string n) { Nome = n; }
    public abstract void Abrir();
}
class ArquivoTexto : Arquivo
{
    public ArquivoTexto(string n) : base(n) { }
    public override void Abrir() => Console.WriteLine($"Q48: Abrindo arquivo texto {Nome}");
}
class ArquivoBinario : Arquivo
{
    public ArquivoBinario(string n) : base(n) { }
    public override void Abrir() => Console.WriteLine($"Q48: Abrindo arquivo binário {Nome}");
}
