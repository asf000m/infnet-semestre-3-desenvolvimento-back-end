namespace Heranca1.Models {
    public class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }

        public Funcionario() { }

        public Funcionario(int id, string nome, string endereco, string telefone, string cargo) {
            if (id <= 0) {
                throw new ArgumentException("Erro: valor do id tem que ser maior que zero");
            }
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cargo = cargo;
        }
    }
}
