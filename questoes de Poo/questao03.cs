using System;

class Program
{
    static void Main()
    {
        Animal a = new Animal("Rex", 3);
        Console.WriteLine($"Q3: Nome={a.Nome}, Idade={a.Idade}");
    }
}

class Animal
{
    public string Nome;
    public int Idade;
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
