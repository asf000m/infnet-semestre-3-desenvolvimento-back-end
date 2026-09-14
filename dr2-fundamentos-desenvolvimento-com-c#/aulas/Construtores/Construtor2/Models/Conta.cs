namespace Construtor2.Models;

class Conta
{
    public int Id {get; set;}
    public String Nome {get; set;}
    public double Saldo {get; private set;}


    public Conta(int id, String nome, double saldo)
    {
        Id = id;
        Nome = nome;
        Saldo = saldo;
    }
}