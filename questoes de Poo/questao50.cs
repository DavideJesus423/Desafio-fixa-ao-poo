using System;

class Program
{
    static void Main()
    {
        Dispositivo d1 = new Smartphone();
        Dispositivo d2 = new Tablet();
        d1.Ligar();
        d2.Ligar();
        ((ITelaTouch)d2).Tocar();
    }
}

abstract class Dispositivo
{
    public abstract void Ligar();
}
class Smartphone : Dispositivo, ITelaTouch
{
    public override void Ligar() => Console.WriteLine("Q50: Smartphone ligado!");
    public void Tocar() => Console.WriteLine("Q50: Toque no smartphone!");
}
class Tablet : Dispositivo, ITelaTouch
{
    public override void Ligar() => Console.WriteLine("Q50: Tablet ligado!");
    public void Tocar() => Console.WriteLine("Q50: Toque no tablet!");
}
interface ITelaTouch
{
    void Tocar();
}
