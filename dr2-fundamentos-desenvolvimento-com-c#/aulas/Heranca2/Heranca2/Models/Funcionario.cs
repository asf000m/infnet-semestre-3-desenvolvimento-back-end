namespace Heranca2.Models {
    public class Funcionario : Pessoa {
        public string Cargo { get; set; }

        public Funcionario() { }

        public Funcionario(int id, string nome, string endereco, string telefone, string cargo) :
            base(id, nome, endereco, telefone) {
            if (string.IsNullOrEmpty(cargo)) {
                throw new ArgumentNullException("Erro: valor do curso inválido");
            }
            Cargo = cargo;
        }

        // Sobreescrita
        public override string ToString() {
            return $"{base.ToString()} {Cargo}";
        }
    }
}
