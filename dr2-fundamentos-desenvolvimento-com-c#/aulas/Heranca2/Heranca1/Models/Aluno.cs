namespace Heranca1.Models {
    public class Aluno {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Curso { get; set; }

        public Aluno() { }

        public Aluno(int id, string nome, string endereco, string telefone, string curso) {
            if (id <= 0) {
                throw new ArgumentException("Erro: valor do id tem que ser maior que zero");
            }
            Id = id;
            if (string.IsNullOrEmpty(nome)) {
                throw new ArgumentException("Erro: valor no nome inválido");
            }
            Nome = nome;
            if (string.IsNullOrEmpty(endereco)) {
                throw new ArgumentException("Erro: valor do endereço inválido");
            }
            Endereco = endereco;
            if (string.IsNullOrEmpty(telefone)) {
                throw new ArgumentException("Erro: valor do telefone inválido");
            }
            Telefone = telefone;
            if (string.IsNullOrEmpty(curso)) {
                throw new ArgumentException("Erro: valor do curso inválido");
            }
            Curso = curso;
        }
    }
}
