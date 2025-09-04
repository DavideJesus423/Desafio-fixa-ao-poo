using System;

class Program
{
    static void Main()
    {
        VeiculoAbs v1 = new CarroEletrico();
        VeiculoAbs v2 = new CarroGasolina();
        v1.CalcularCombustivel();
        v1.Viajar();
        v2.CalcularCombustivel();
        v2.Viajar();
    }
}

abstract class VeiculoAbs
{
    public abstract void CalcularCombustivel();
    public abstract void Viajar();
}
class CarroEletrico : VeiculoAbs
{
    public override void CalcularCombustivel() => Console.WriteLine("Q55: Calculando carga elétrica");
    public override void Viajar() => Console.WriteLine("Q55: Viajando com carro elétrico");
}
class CarroGasolina : VeiculoAbs
{
    public override void CalcularCombustivel() => Console.WriteLine("Q55: Calculando consumo de gasolina");
    public override void Viajar() => Console.WriteLine("Q55: Viajando com carro a gasolina");
}
