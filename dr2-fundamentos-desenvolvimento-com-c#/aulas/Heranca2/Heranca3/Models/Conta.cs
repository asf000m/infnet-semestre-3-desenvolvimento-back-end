namespace Heranca3.Models;

class Conta
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Saldo { get; set; }


    public Conta(int id, string nome, double saldo) {
        if (id <= 0)
            throw new ArgumentException("Erro: valor id inválido");
        Id = id;

        if (string.IsNullOrEmpty(nome))
            throw new ArgumentException("Erro: valor do nome inválido");
        Nome = nome;

        if (saldo < 0)
            throw new ArgumentException("Erro: valor saldo inálido");
        Saldo = saldo;
    }

    public void Creditar(double valor) {
        if (valor <= 0) {
            throw new ArgumentException("Erro: valor do crédito inválido");
        }
        Saldo += valor;
    }

    public override string ToString() {
        return $"{Id} {Nome} {Saldo}";
    }
}