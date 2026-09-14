public class Exercicio03 {
    public static void main(String[] args) {
        Produto2 produto001 = new Produto2();
        
        produto001.nome = "Arroz 1 kg";
        produto001.alterarPreco(5.90);
        produto001.alterarQuantidade(100);
        
        produto001.exibirInformacoes();
    }
}

class Produto2 {
    String nome;
    private double preco;
    private int quantidadeEmEstoque;

    public void alterarPreco(double novoPreco) {
        preco = novoPreco;
    }

    public void alterarQuantidade(int novaQuantidade) {
        quantidadeEmEstoque = novaQuantidade;
    }

    public void exibirInformacoes() {
        System.out.printf("Nome do produto: %s\nPreço: R$ %.2f\nQuantidade: %d\n",
            nome, preco, quantidadeEmEstoque
        );
    }
}