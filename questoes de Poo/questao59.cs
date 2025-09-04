using System;

class Program
{
    static void Main()
    {
        Notificador n1 = new EmailNotificador();
        Notificador n2 = new SMSNotificador();
        n1.Enviar();
        n2.Enviar();
    }
}

abstract class Notificador { public abstract void Enviar(); }
class EmailNotificador : Notificador
{
    public override void Enviar() => Console.WriteLine("Q59: Enviando notificação por Email");
}
class SMSNotificador : Notificador
{
    public override void Enviar() => Console.WriteLine("Q59: Enviando notificação por SMS");
}
