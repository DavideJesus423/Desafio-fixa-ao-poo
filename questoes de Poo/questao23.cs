using System;

class Program
{
    static void Main()
    {
        AlunoEnc a = new AlunoEnc();
        a.Nota = 8.5;
        Console.WriteLine($"Q23: Nota = {a.Nota}");
    }
}

class AlunoEnc
{
    private double nota;
    public double Nota
    {
        get => nota;
        set
        {
            if (value >= 0 && value <= 10) nota = value;
            else Console.WriteLine("Q23: Nota inválida!");
        }
    }
}
