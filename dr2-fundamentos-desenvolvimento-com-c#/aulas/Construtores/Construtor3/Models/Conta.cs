namespace Construtor3.Models;

class Conta
{
    private int _id;
    private String _nome;
    public double Saldo {get; private set;}


    public Conta() {}

    public Conta(int id, String nome)
    {
        Id = id;
        Nome = nome;
        Saldo = 0;
    }

    public Conta(int id, String nome, double saldo)
    {
        Id = id;
        Nome = nome;
        if (saldo < 0)
            this new ArgumentException("Erro: Saldo inválido.");
        Saldo = saldo;
    }

    public int Id
    {
        get {return _id;}
        set 
        {
            if (value <= 0)
                throw new ArgumentException("Erro: ID inválido.");
            _id = value;
        }
    }

    public String Nome
    {
        get {return _nome;}
        set 
        {
            if (String.IsNullOrEmpty(value) || value.Length < 2)
                throw new ArgumentException("Erro: Nome inválido.");
            _nome = value;
        }
    }

    public void Creditar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Erro: Valor inválido.");
        }

        Saldo += valor;
    }

    public void Debitar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Erro: Valor inválido.");
        }

        if (valor > Saldo)
        {
            throw new ArgumentException("Erro: Valor maior que o saldo disponível.");
        }

        Saldo -= valor;
    }
}