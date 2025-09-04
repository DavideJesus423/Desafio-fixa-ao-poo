using System;

class Program
{
    static void Main()
    {
        Aviao a = new Aviao();
        Console.WriteLine($"Q38: {a.Mover()}");
    }
}

class TransporteBase
{
    public virtual string Mover() => "Movendo...";
}
class Aviao : TransporteBase
{
    public override string Mover() => "Voar";
    public int Altitude = 10000;
}
