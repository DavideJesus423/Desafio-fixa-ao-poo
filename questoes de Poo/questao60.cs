using System;

class Program
{
    static void Main()
    {
        Simulador s1 = new SimuladorJogo();
        Simulador s2 = new SimuladorTreinamento();
        s1.Iniciar(); s1.Executar(); s1.Finalizar();
        s2.Iniciar(); s2.Executar(); s2.Finalizar();
    }
}

abstract class Simulador
{
    public abstract void Iniciar();
    public abstract void Executar();
    public abstract void Finalizar();
}
class SimuladorJogo : Simulador
{
    public override void Iniciar() => Console.WriteLine("Q60: Iniciando jogo");
    public override void Executar() => Console.WriteLine("Q60: Jogando...");
    public override void Finalizar() => Console.WriteLine("Q60: Jogo finalizado");
}
class SimuladorTreinamento : Simulador
{
    public override void Iniciar() => Console.WriteLine("Q60: Iniciando treinamento");
    public override void Executar() => Console.WriteLine("Q60: Treinando...");
    public override void Finalizar() => Console.WriteLine("Q60: Treinamento finalizado");
}
