namespace Exercicio03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Ingresso
{
    String nomeDoShow;
    double preco;
    int quantidadeDisponivel;

    
    void AtualizarPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    void AtualizarQuantidade(int novaQuantidade)
    {
        quantidadeDisponivel = novaQuantidade;
    }

    void ExibirInformacoes()
    {
        Console.WriteLine(
            $"Nome:\t\t{nomeDoShow}\nPreço:\t\t{preco}\n" +
            $"Quantidade de ingressos:\t{quantidadeDisponivel}"
        );
    }
}