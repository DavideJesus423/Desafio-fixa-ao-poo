using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<PessoaPoli> pessoas = new List<PessoaPoli>
        {
            new Cliente("Pedro"),
            new Fornecedor("Empresa X")
        };
        foreach (var p in pessoas) Console.WriteLine($"Q47: {p.Apresentar()}");
    }
}

abstract class PessoaPoli
{
    public string Nome;
    public PessoaPoli(string n) { Nome = n; }
    public abstract string Apresentar();
}
class Cliente : PessoaPoli
{
    public Cliente(string n) : base(n) { }
    public override string Apresentar() => $"Cliente: {Nome}";
}
class Fornecedor : PessoaPoli
{
    public Fornecedor(string n) : base(n) { }
    public override string Apresentar() => $"Fornecedor: {Nome}";
}
