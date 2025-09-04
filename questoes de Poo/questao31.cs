using System;

class Program
{
    static void Main()
    {
        AnimalBase a = new Cachorro();
        Console.WriteLine($"Q31: Som = {a.FazerSom()}");
    }
}

class AnimalBase
{
    public virtual string FazerSom() => "Som genérico";
}
class Cachorro : AnimalBase
{
    public override string FazerSom() => "Latir";
}
