using System;

class Program
{
    static void Main()
    {
        ItemMenu i1 = new PratoPrincipal();
        ItemMenu i2 = new Sobremesa();
        i1.Preparar();
        i2.Preparar();
    }
}

abstract class ItemMenu { public abstract void Preparar(); }
class PratoPrincipal : ItemMenu
{
    public override void Preparar() => Console.WriteLine("Q58: Preparando prato principal");
}
class Sobremesa : ItemMenu
{
    public override void Preparar() => Console.WriteLine("Q58: Preparando sobremesa");
}
