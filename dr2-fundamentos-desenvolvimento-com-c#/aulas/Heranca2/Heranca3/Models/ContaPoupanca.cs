namespace Heranca3.Models {
    public class ContaPoupanca : Conta {
        public double Taxa { get; set; }

        public ContaPoupanca(int id, string nome, double saldo, double taxa) : base(id, nome, saldo) {
            if (taxa <= 0) {
                throw new ArgumentException("Erro: valor da taxa inválido.");
            }
            Taxa = taxa;
        }

        public void Debitar(double valor) {
            if (valor <= 0) {
                throw new ArgumentException("Erro: valor do dédito inválido");
            }
            if (valor > Saldo) {
                throw new ArgumentException("Erro: saldo insuficiente para o débito");
            }
            Saldo -= valor;
        }

        public double CalcularSaldo() {
            return Saldo + (Saldo * Taxa);
        }

        public override string ToString() {
            return $"Conta poupança:\t{Id} {Nome} {CalcularSaldo()} {Taxa}";
        }
    }
}
