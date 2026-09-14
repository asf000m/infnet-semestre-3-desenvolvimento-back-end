namespace Heranca2.Models {
    public class Aluno : Pessoa {
        public string Curso { get; set; }

        public Aluno() { }

        public Aluno(int id, string nome, string endereco, string telefone, string curso) : 
            base(id, nome, endereco, telefone) {
            if (string.IsNullOrEmpty(curso)) {
                throw new ArgumentNullException("Erro: valor do curso inválido");
            }
            Curso = curso;
        }

        // Sobreescrita
        public override string ToString() {
            return $"{base.ToString()} {Curso}";
        }
    }
}
