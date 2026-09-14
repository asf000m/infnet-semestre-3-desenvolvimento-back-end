namespace Heranca4.Models {
    public class ContaEspecial : Conta {
        public double Especial { get; set; }

        public ContaEspecial(int id, string nome, double saldo, double especial) : 
            base(id, nome, saldo) { 
            if (especial <= 0) {
                throw new ArgumentException("Erro: valor especial inálido");
            }
            Especial = especial;
        }

        public void Debitar(double valor) {
            if (valor <= 0) {
                throw new ArgumentException("Erro: valor do dédito inválido");
            }
            if (valor > CalcularSaldo()) {
                throw new ArgumentException("Erro: saldo insuficiente para o débito");
            }
            Saldo -= valor;
        }

        public double CalcularSaldo() {
            return Saldo + Especial;
        }

        public override string ToString() {
            return $"{base.ToString()} {CalcularSaldo()} {Especial}";    
        }
    }
}
