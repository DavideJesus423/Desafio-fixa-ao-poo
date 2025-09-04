using System;

class Program
{
    static void Main()
    {
        PessoaEnc p = new PessoaEnc();
        p.Idade = 20;
        Console.WriteLine($"Q21: Idade = {p.Idade}");
    }
}

class PessoaEnc
{
    private int _idade;
    public int Idade
    {
        get => _idade;
        set => _idade = value;
    }
}
