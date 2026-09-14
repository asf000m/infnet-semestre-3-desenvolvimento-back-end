namespace Exercicio04;

class Program
{
    static void Main(string[] args)
    {
        Ingresso ingresso001 = new();

        ingresso001.nomeDoShow = "Show do Artista";
        ingresso001.preco = 100;
        ingresso001.quantidadeDisponivel = 500;

        ingresso001.ExibirInformacoes();

        Console.WriteLine();

        ingresso001.AtualizarPreco(120);
        ingresso001.AtualizarQuantidade(200);

        ingresso001.ExibirInformacoes();
    }
}

class Ingresso
{
    public String nomeDoShow;
    public double preco;
    public int quantidadeDisponivel;

    
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
}