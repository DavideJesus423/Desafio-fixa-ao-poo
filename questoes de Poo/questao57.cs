using System;

class Program
{
    static void Main()
    {
        Relatorio r1 = new RelatorioPDF();
        Relatorio r2 = new RelatorioExcel();
        r1.Gerar();
        r2.Gerar();
    }
}

abstract class Relatorio { public abstract void Gerar(); }
class RelatorioPDF : Relatorio
{
    public override void Gerar() => Console.WriteLine("Q57: Relatório PDF gerado");
}
class RelatorioExcel : Relatorio
{
    public override void Gerar() => Console.WriteLine("Q57: Relatório Excel gerado");
}
