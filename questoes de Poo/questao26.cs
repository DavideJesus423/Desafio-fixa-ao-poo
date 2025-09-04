using System;

class Program
{
    static void Main()
    {
        UsuarioEnc u = new UsuarioEnc("1234");
        Console.WriteLine($"Q26: Autenticação = {u.Autenticar("1234")}");
    }
}

class UsuarioEnc
{
    private string senha;
    public UsuarioEnc(string s) { senha = s; }

    public bool Autenticar(string tentativa) => tentativa == senha;
}
