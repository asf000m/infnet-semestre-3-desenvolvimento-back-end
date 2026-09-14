namespace Encapsulamento5.Models;

public class Conta
{
    private int _id;
    private String _nome;
    private double _saldo;

    public int Id
    {
        get {return _id;}
        set {_id = value;}
    }

    public String Nome
    {
        get {return _nome;}
        set {_nome = value;}
    }

    public double Saldo
    {
        get {return _saldo;}
        set {_saldo = value;}
    }
}