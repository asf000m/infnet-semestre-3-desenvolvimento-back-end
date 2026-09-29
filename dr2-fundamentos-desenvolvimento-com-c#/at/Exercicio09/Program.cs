namespace Exercicio09;

class Program
{
    static void Main(string[] args)
    {
        const int QTD_PRODUTOS = 5;
        
        Produto[] produtos = new Produto[QTD_PRODUTOS];
        string nomeProduto;
        int quantidade;
        decimal precoUnitario;
        int opcao;
        

        bool encerrado = false;
        int idxProdutos = 0;
        
        while (!encerrado)
        {
            Console.WriteLine("\n===== CADASTRO DE PRODUTOS =====");
            Console.WriteLine(
                "1. Inserir produto\n" +
                "2. Listar produtos\n" +
                "3. Sair\n"
            );

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (idxProdutos < QTD_PRODUTOS)
                    {
                        Console.Write("Produto: ");
                        nomeProduto = Console.ReadLine();
                        
                        Console.Write("Quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());
                        
                        Console.Write("Preço unitário: ");
                        precoUnitario = decimal.Parse(Console.ReadLine());

                        try
                        {
                            produtos[idxProdutos++] = new Produto(
                                nomeProduto, quantidade, precoUnitario
                            );
                        } 
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("-- Erro: Entrada de dados inválida. --");
                            Console.WriteLine(e.Message);
                        }

                    }
                    else
                        Console.WriteLine("Quantidade máxima de produtos atingida.");
                    break;
                
                case 2:
                    foreach (Produto produto in produtos)
                    {
                        if (produto != null)
                            Console.WriteLine(
                                $"Produto: {produto.GetNomeProduto()} | " +
                                $"Quantidade: {produto.GetQuantidade()} | " +
                                $"Preço: R$ {produto.GetPrecoUnitario():F2}"
                            );
                    }
                    break;
                
                case 3:
                    encerrado = true;
                    break;
                
                default:
                    Console.WriteLine("-- Erro: Opção inválida. --");
                    break;
            }
        }
    }
}


class Produto
{
    private string nomeProduto;
    private int quantidade;
    private decimal precoUnitario;


    // Constructors
    public Produto(string nomeProduto, int quantidade, decimal precoUnitario)
    {
        if (nomeProduto.Length < 2)
            throw new ArgumentException("-- Nome do produto inválido. --");
        else
            this.nomeProduto = nomeProduto;
        
        if (quantidade <= 0)
            throw new ArgumentException("-- Quantidade inválida. --");
        else
            this.quantidade = quantidade;
        
        if (precoUnitario <= 0)
            throw new ArgumentException("-- Preço unitário inválido. --");
        else
            this.precoUnitario = precoUnitario;
    }

    // Methods
    public string GetNomeProduto()
    {
        return nomeProduto;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }

    public decimal GetPrecoUnitario()
    {
        return precoUnitario;
    }
}