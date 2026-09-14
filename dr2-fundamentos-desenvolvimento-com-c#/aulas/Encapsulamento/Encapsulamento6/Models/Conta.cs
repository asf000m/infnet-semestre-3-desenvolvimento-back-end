namespace Encapsulamento6.Models;

public class Conta
{
    private int _id;
    private String _nome;
    private double _saldo;

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

    public double Saldo
    {
        get {return _saldo;}
        set 
        {
            if (value < 0)
                throw new ArgumentException("Erro: Saldo inválido.");
            _saldo = value;
        }
    }
}