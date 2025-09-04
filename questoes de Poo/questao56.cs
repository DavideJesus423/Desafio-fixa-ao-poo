using System;

class Program
{
    static void Main()
    {
        Estrategia e1 = new Ataque();
        Estrategia e2 = new Defesa();
        e1.Executar();
        e2.Executar();
    }
}

abstract class Estrategia { public abstract void Executar(); }
class Ataque : Estrategia
{
    public override void Executar() => Console.WriteLine("Q56: Atacando o inimigo");
}
class Defesa : Estrategia
{
    public override void Executar() => Console.WriteLine("Q56: Defendendo posição");
}
