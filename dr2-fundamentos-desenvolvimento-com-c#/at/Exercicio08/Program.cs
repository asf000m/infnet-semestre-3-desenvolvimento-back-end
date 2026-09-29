namespace Exercicio08;

class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new();
        gerente.Nome = "Fulano Silva";
        gerente.Cargo = "Gerende de Vendas";
        
        Console.WriteLine(
            $"""
            Funcionário: {gerente.Nome}
            Cargo: {gerente.Cargo}
            Salário: R$ {gerente.SalarioBase:F2}
            """
        );
    }
}


class Funcionario
{
    // Attributes
    public string Nome {get; set;} = "";
    public string Cargo {get; set;} = "";
    public decimal SalarioBase {get; set;} = 1621;
}

class Gerente : Funcionario
{
    public Gerente() : base()
    {
        // Bônus de 20% no salário.
        SalarioBase *= 1.2M;
    }
}