public class Exercicio05 {
    public static void main(String[] args) {
        Produto4 produto001 = new Produto4();
        
        produto001.setNome("Arroz 1 kg");
        produto001.setPreco(4.59);
        produto001.alterarPreco(5.90);
        produto001.alterarQuantidade(100);
        
        produto001.exibirInformacoes();
        System.out.println(produto001.getNome() + " - R$ " + produto001.getPreco());

        
        System.out.println();

        
        Produto4 produto002 = new Produto4();
        
        produto002.setNome("Limpador 1 L");
        produto002.setQuantidadeEmEstoque(15);
        produto002.alterarPreco(7.69);
        produto002.alterarQuantidade(10);
        
        produto002.exibirInformacoes();
        System.out.println(produto002.getNome() + " - " + produto002.getQuantidadeEmEstoque() + " unidades");
    }
}

class Produto4 {
    private String nome;
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

    // Getters e Setters são úteis para validar os dados inseridos ou modificar 
    // a saída/retorno desses dados.

    public String getNome() {
        return nome;
    }

    public double getPreco() {
        return preco;
    }

    public int getQuantidadeEmEstoque() {
        return quantidadeEmEstoque;
    }

    public void setNome(String nome) {
        if (nome.length() > 3)
            this.nome = nome;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    public void setQuantidadeEmEstoque(int quantidadeEmEstoque) {
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }
}