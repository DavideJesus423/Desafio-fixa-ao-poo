using System;

class Program
{
    static void Main()
    {
        CarroEnc c = new CarroEnc();
        c.Acelerar(50);
        c.Acelerar(180);
        Console.WriteLine($"Q25: Velocidade = {c.Velocidade}");
    }
}

class CarroEnc
{
    private double velocidade = 0;
    public double Velocidade => velocidade;

    public void Acelerar(double v)
    {
        velocidade += v;
        if (velocidade > 200) velocidade = 200;
    }
}
