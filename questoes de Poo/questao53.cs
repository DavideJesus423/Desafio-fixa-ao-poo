using System;

class Program
{
    static void Main()
    {
        Pagamento p1 = new CartaoCredito();
        Pagamento p2 = new Boleto();
        p1.Processar();
        p2.Processar();
    }
}

abstract class Pagamento { public abstract void Processar(); }
class CartaoCredito : Pagamento
{
    public override void Processar() => Console.WriteLine("Q53: Pagamento com cartão de crédito processado");
}
class Boleto : Pagamento
{
    public override void Processar() => Console.WriteLine("Q53: Pagamento por boleto processado");
}
