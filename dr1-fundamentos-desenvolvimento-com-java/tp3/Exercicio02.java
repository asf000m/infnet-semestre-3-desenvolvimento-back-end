public class Exercicio02 {
    public static void main(String[] args) {
        Produto1 produto001 = new Produto1();

        // Todo produto tem um nome para que possa ser identificado e diferenciado.
        produto001.nome = "Arroz 1 kg";
        // Todo produto precisa ter um preço para que possa ser negociado.
        produto001.preco = 5.90;
        // É necessário saber a quantidade disponível do produto.
        produto001.quantidadeEmEstoque = 100;
    }
}

class Produto1 {
    String nome;
    double preco;
    int quantidadeEmEstoque;
}