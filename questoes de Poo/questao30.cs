using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Configuracao cfg = new Configuracao();
        cfg.Set("tema", "escuro");
        Console.WriteLine($"Q30: Tema = {cfg.Get("tema")}");
    }
}

class Configuracao
{
    private Dictionary<string, string> dados = new Dictionary<string, string>();
    public void Set(string chave, string valor) => dados[chave] = valor;
    public string Get(string chave) => dados.ContainsKey(chave) ? dados[chave] : "Não encontrado";
}
