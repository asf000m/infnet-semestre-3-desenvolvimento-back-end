public class Exercicio06 {
    public static void main(String[] args) {

        // O construtor recebe os argumentos e realiza a inicialização dos 
        // atributis do objeto.

        Produto5 produto001 = new Produto5("Arroz 1 kg", 4.59, 100);
        
        produto001.alterarPreco(5.90);
        
        produto001.exibirInformacoes();
        System.out.println(produto001.getNome() + " - R$ " + produto001.getPreco());

        
        System.out.println();

        // Usar um construtor faz com que seja possível validar a entrada dos
        // dados para os atributos e também condiciona a criação de um objeto
        // à necessidade de informar os argumentos.
        
        Produto5 produto002 = new Produto5("Limpador 1 L", 2.29, 15);
        
        produto002.alterarPreco(3.69);
        produto002.alterarQuantidade(10);
        
        produto002.exibirInformacoes();
        System.out.println(produto002.getNome() + " - " + produto002.getQuantidadeEmEstoque() + " unidades");
    }
}


class Produto5 {
    private String nome;
    private double preco;
    private int quantidadeEmEstoque;


    Produto5(String nome, double preco, int quantidadeEmEstoque) {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }


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