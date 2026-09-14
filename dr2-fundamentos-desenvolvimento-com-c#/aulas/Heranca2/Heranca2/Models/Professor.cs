namespace Heranca2.Models {
    public class Professor : Pessoa {
        public string Titulacao { get; set; }

        public Professor() { }

        public Professor(int id, string nome, string endereco, string telefone, string titulacao) :
            base(id, nome, endereco, telefone) {
            if (string.IsNullOrEmpty(titulacao)) {
                throw new ArgumentNullException("Erro: valor do curso inválido");
            }
            Titulacao = titulacao;
        }

        // Sobreescrita
        public override string ToString() {
            return $"{base.ToString()} {Titulacao}";
        }
    }
}
