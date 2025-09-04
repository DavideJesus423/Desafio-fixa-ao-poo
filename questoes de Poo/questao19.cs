using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Agenda ag = new Agenda(new List<string> { "João", "Maria" });
        Console.WriteLine($"Q19: Contato encontrado = {ag.BuscarContato("Maria")}");
    }
}

class Agenda
{
    private List<string> Contatos;
    public Agenda(List<string> contatos) { Contatos = contatos; }
    public string BuscarContato(string nome) => Contatos.Contains(nome) ? nome : "Não encontrado";
}
