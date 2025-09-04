using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Banco b = new Banco();
        b.AdicionarConta(1);
        b.AdicionarConta(2);
        b.RemoverConta(1);
        Console.WriteLine("Q27: Operações concluídas!");
    }
}

class Banco
{
    private List<int> contas = new List<int>();

    public void AdicionarConta(int id) => contas.Add(id);
    public void RemoverConta(int id) => contas.Remove(id);
}
