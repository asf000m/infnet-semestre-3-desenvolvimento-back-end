namespace Exercicio06;

class Program
{
    static void Main(string[] args)
    {
        Ingresso ingresso001 = new("Show do Artista", 100, 500);

        ingresso001.ExibirInformacoes();

        Console.WriteLine();

        ingresso001.AtualizarPreco(120);
        ingresso001.AtualizarQuantidade(200);

        ingresso001.ExibirInformacoes();

        Console.WriteLine();

        String nomeShow = ingresso001.GetNomeDoShow();
        double precoShow = ingresso001.GetPreco();
        int qtdShow = ingresso001.GetQuantidadeDisponivel();

        Console.WriteLine($"{nomeShow} | {precoShow} | {qtdShow}");
    }
}

class Ingresso
{
    private String nomeDoShow;
    private double preco;
    private int quantidadeDisponivel;


    // Usar um construtor permite que um objeto da classe seja criado somente
    // quando é provido os argumentos definidos nos parâmetros do construtor,
    // sem a necessidade de usar os métodos setters para cada atributo.
    
    public Ingresso(String nomeDoShow, double preco, int quantidadeDisponivel)
    {
        this.nomeDoShow = nomeDoShow;
        this.preco = preco;
        this.quantidadeDisponivel = quantidadeDisponivel;
    }


    public void AtualizarPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public void AtualizarQuantidade(int novaQuantidade)
    {
        quantidadeDisponivel = novaQuantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine(
            $"Nome:\t\t{nomeDoShow}\nPreço:\t\t{preco}\n" +
            $"Quantidade:\t{quantidadeDisponivel}"
        );
    }


    public void SetNomeDoShow(String novoNome)
    {
        nomeDoShow = novoNome;
    }

    public void SetPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public void SetQuantidadeDisponivel(int novaQtd)
    {
        quantidadeDisponivel = novaQtd;
    }

    public String GetNomeDoShow()
    {
        return nomeDoShow;
    }

    public double GetPreco()
    {
        return preco;
    }

    public int GetQuantidadeDisponivel()
    {
        return quantidadeDisponivel;
    }
}