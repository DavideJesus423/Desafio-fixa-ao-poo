using System;

class Program
{
    static void Main()
    {
        Data d = new Data(4, 9, 2025);
        Console.WriteLine($"Q13: {d.Formatar()}");
    }
}

class Data
{
    public int Dia, Mes, Ano;
    public Data(int d, int m, int a) { Dia = d; Mes = m; Ano = a; }
    public string Formatar() => $"{Dia:D2}/{Mes:D2}/{Ano}";
}
