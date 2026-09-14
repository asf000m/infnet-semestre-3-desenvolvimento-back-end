namespace Heranca3.Models {
    public class ContaComum : Conta {

        public ContaComum(int id, string nome, double saldo) : base(id, nome, saldo)
        {
            
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

        public override string ToString() {
            return $"Conta comum:\t{base.ToString()}";    
        }
    }
}
