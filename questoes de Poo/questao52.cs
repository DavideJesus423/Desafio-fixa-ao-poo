using System;

class Program
{
    static void Main()
    {
        AnimalAbs a1 = new Peixe();
        AnimalAbs a2 = new Passaro();
        Console.WriteLine($"Q52: {a1.Mover()}");
        Console.WriteLine($"Q52: {a2.Mover()}");
    }
}

abstract class AnimalAbs { public abstract string Mover(); }
class Peixe : AnimalAbs { public override string Mover() => "Nadar"; }
class Passaro : AnimalAbs { public override string Mover() => "Voar"; }
