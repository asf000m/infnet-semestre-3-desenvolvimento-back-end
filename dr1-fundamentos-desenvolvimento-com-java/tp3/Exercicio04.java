public class Exercicio04 {
    public static void main(String[] args) {
        Produto3 produto001 = new Produto3();
        
        produto001.nome = "Arroz 1 kg";
        produto001.alterarPreco(5.90);
        produto001.alterarQuantidade(100);
        
        produto001.exibirInformacoes();

        
        System.out.println();

        
        Produto3 produto002 = new Produto3();
        
        produto002.nome = "Limpador 1 L";
        produto002.alterarPreco(7.69);
        produto002.alterarQuantidade(10);
        
        produto002.exibirInformacoes();
    }
}

class Produto3 {
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