using System.Globalization;

namespace Exercicio09B;

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

        string caminhoArquivo = "estoque.txt";
        
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
                // Inserir produto
                case 1:
                    if (idxProdutos < QTD_PRODUTOS)
                    {
                        Console.Write("Produto: ");
                        nomeProduto = Console.ReadLine();
                        
                        Console.Write("Quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());
                        
                        Console.Write("Preço unitário: ");
                        precoUnitario = decimal.Parse(
                            Console.ReadLine(), 
                            CultureInfo.CurrentCulture
                        );

                        Produto produto = new(nomeProduto, quantidade, precoUnitario);

                        try
                        {
                            // Salva em um array.
                            // produtos[idxProdutos++] = new Produto(
                            //     nomeProduto, quantidade, precoUnitario
                            // );

                            // Salva em um arquivo.
                            using (StreamWriter writer = new StreamWriter(caminhoArquivo, append: true))
                            {
                                writer.WriteLine(produto.ToCSV());
                            }
                            
                            idxProdutos++;
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("-- Erro: Entrada de dados inválida. --");
                            Console.WriteLine(e.Message);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("-- Erro: Falha ao gravar o arquivo. --");
                            Console.WriteLine(e.Message);
                        }

                    }
                    else
                        Console.WriteLine("Quantidade máxima de produtos atingida.");
                    break;
                
                // Listar produtos
                case 2:

                    try
                    {
                        using (StreamReader reader = new StreamReader(caminhoArquivo))
                        {
                            int i = 0;
                            string linha;
                            
                            while ((linha = reader.ReadLine()) != null)
                            {
                                string[] linhaArray = linha.Split(",");
                                string nome = linhaArray[0];
                                int qtd = int.Parse(linhaArray[1]);
                                decimal precoUnt = decimal.Parse(
                                    linhaArray[2],
                                    CultureInfo.InvariantCulture);

                                produtos[i++] = new Produto(nome, qtd, precoUnt);
                            }
                        }
                        
                        foreach (Produto produto in produtos)
                        {
                            if (produto != null)
                                Console.WriteLine(produto.ToString());
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("-- Erro: Falha ao ler arquivo. --");
                        Console.WriteLine(e.Message);
                    }
                    break;
                
                // Sair
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

    public override string ToString()
    {
        return FormattableString.Invariant($"Produto: {nomeProduto} | Quantidade: {quantidade} | Preço: R$ {precoUnitario}");
    }

    public string ToCSV()
    {
        return FormattableString.Invariant($"{nomeProduto},{quantidade},{precoUnitario}");
    }
}