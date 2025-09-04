using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<AnimalPoli> animais = new List<AnimalPoli>
        {
            new Mamifero(),
            new Ave()
        };
        foreach (var a in animais) Console.WriteLine($"Q41: {a.Comer()}");
    }
}

class AnimalPoli
{
    public virtual string Comer() => "Comendo...";
}
class Mamifero : AnimalPoli
{
    public override string Comer() => "Mamífero comendo";
}
class Ave : AnimalPoli
{
    public override string Comer() => "Ave comendo";
}
