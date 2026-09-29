namespace Exercicio07;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta01 = new("João Silva");
        conta01.Depositar(500);
        conta01.ExibirSaldo();
        conta01.Sacar(700);
        conta01.Sacar(200);
        conta01.ExibirSaldo();
    }
}


class ContaBancaria
{
    // Attributes
    private string Titular {get; set;} = "";
    private decimal Saldo {get; set;} = 0;


    // Constructors
    public ContaBancaria(string titular)
    {
        Titular = titular;
    }


    // Methods
    public void Depositar(decimal valor)
    {
        if (valor >= 0)
        {
            Saldo += valor;
            
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        }
        else
            Console.WriteLine("Erro: O valor do depósito deve ser positivo!");
    }

    public void Sacar(decimal valor)
    {
        Console.WriteLine($"Tentativa de saque: R$ {valor:F2}");

        if (Saldo >= valor && valor >= 0)
        {
            Saldo -= valor;

            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }
        else
            Console.WriteLine("Erro: Saldo insuficiente para realizar o saque!");
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    }


    // Getters and Setters
    public decimal GetSaldo()
    {
        return Saldo;
    }
    
    public string GetTitular()
    {
        return Titular;
    }
}