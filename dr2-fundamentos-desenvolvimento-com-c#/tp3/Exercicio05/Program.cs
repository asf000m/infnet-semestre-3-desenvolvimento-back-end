namespace Exercicio05;

class Program
{
    static void Main(string[] args)
    {
        Ingresso ingresso001 = new();

        ingresso001.SetNomeDoShow("Show do Artista");
        ingresso001.SetPreco(100);
        ingresso001.SetQuantidadeDisponivel(500);

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

    // Os getters e setters protegem os atributos de serem modificados ou
    // acessados diretamente. Também podem ser eles podem ser alterados ou
    // manipulados de acordo com o objetivo da classe.

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