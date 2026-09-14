namespace Heranca2.Models {

    // Define a classe Pessoa como abstrata, logo essa classe não pode ser instanciada e serve 
    // apenas para impelmentar a herança
    public abstract class Pessoa {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Pessoa() { }

        public Pessoa(int id, string nome, string endereco, string telefone) {
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
        }

        // Sobreescrita o comportamento de um método
        public override string ToString() {
            return $"{Id} {Nome} {Endereco} {Telefone}";
        }
    }
}
