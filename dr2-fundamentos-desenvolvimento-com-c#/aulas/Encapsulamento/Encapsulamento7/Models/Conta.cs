namespace Encapsulamento7.Models;

public class Conta
{
    private int _id;
    private String _nome;
    public double Saldo {get; private set;}

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