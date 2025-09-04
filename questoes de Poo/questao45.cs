using System;

class Program
{
    static void Main()
    {
        Triatleta t = new Triatleta();
        t.Competir();
    }
}

interface INadador { void Nadar(); }
interface ICorredor { void Correr(); }

class Triatleta : INadador, ICorredor
{
    public void Nadar() => Console.WriteLine("Q45: Nadando...");
    public void Correr() => Console.WriteLine("Q45: Correndo...");
    public void Competir()
    {
        Nadar();
        Correr();
        Console.WriteLine("Q45: Competindo!");
    }
}
