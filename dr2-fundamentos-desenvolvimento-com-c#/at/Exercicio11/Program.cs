namespace Exercicio11;

class Program
{
    static void Main(string[] args)
    {
        bool encerrado = false;
        int opcao;

        string caminhoArquivo = "contatos.txt";


        while (!encerrado)
        {
            Console.WriteLine(
                "===== CADASTRAR CONTATOS =====\n\n" +
                "1 - Adicionar novo contato\n" +
                "2 - Listar contatos cadastrados\n" +
                "3 - Sair\n"
            );
            Console.Write("> ");
            opcao = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine();

            switch (opcao)
            {
                // Adicionar novo contato
                case 1:
                    Contato contato;

                    try
                    {
                        Console.WriteLine("Informe os dados do contato:");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine() ?? "";
                        Console.Write("Telefone (apenas números): ");
                        string telefone = Console.ReadLine() ?? "";
                        Console.Write("Email: ");
                        string email = Console.ReadLine() ?? "";

                        contato = new Contato(nome, telefone, email);

                        Console.WriteLine();
                        
                        // Salva o contato no arquivo.
                        using(StreamWriter writer = new StreamWriter(caminhoArquivo, append: true))
                        {
                            writer.WriteLine(contato.ToCSV());
                            Console.WriteLine($"- Contato cadastrado com sucesso! -\n");
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("\n-- Erro: Dados informados inválidos. --");
                        Console.WriteLine(e.Message + "\n");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("\n-- Erro: Problema ao gravar no arquivo. --");
                        Console.WriteLine(e.Message + "\n");
                    }
                    
                    break;
                
                // Listar contatos cadastrados
                case 2:

                    try
                    {
                        string linha;
                        int contatosCadastrados = 0;
                        
                        using (StreamReader reader = new StreamReader(caminhoArquivo))
                        {
                            while ((linha = reader.ReadLine()) != null)
                            {
                                string[] dados = linha.Trim().Split(",");
                                string nome = dados[0];
                                string telefone = dados[1];
                                string email = dados[2];
                                
                                Console.WriteLine(
                                    $"Nome: {nome} |" +
                                    $"Telefone: {telefone} |" +
                                    $"Email: {email}"
                                );

                                contatosCadastrados++;
                            }

                            if (contatosCadastrados == 0)
                                Console.WriteLine("\n-- Erro: Nenhum contato cadastrado. --");
                        }

                        Console.WriteLine();
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("\n-- Erro: Arquivo não encontrado. --");
                        Console.WriteLine(e.Message + "\n");
                    }
                
                    break;
                
                // Sair
                case 3:
                    encerrado = true;
                    
                    Console.WriteLine("\n-- Fim do programa. --\n");
                    break;

                default:
                    Console.WriteLine("\n-- Erro: Opção inválida. --\n");
                    break;
            }
        }
    }
}


public class Contato
{
    // Attributes
    private string Nome;
    private string Telefone;
    private string Email;

    // Constructors
    public Contato(string nomeContato, string telefone, string email)
    {
        Nome = (nomeContato.Length < 2) ? 
            throw new ArgumentException("- Erro: Nome inválido. Deve conter no mínimo 2 caracteres. -") : 
            nomeContato;
        
        Telefone = (telefone.Length != 11) ?
            throw new ArgumentException("- Erro: Telefone inválido. Deve conter 11 dígitos. -") :
            telefone;
        
        Email = !EmailValido(email) ?
            throw new ArgumentException("- Erro: Email inválido. Deve ter apenas um arroba. -") :
            email;
    }

    // Methods
    public string ToCSV()
    {
        return $"{Nome},{TelefoneFormatado(Telefone)},{Email}";
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Telefone: {TelefoneFormatado(Telefone)} | Email: {Email}";
    }

    public string GetNome()
    {
        return Nome;
    }

    public string GetTelefone()
    {
        return Telefone;
    }

    private bool EmailValido(string email)
    {
        int arrobas = 0;
        
        foreach (char c in email)
        {
            if (c == '@')
                arrobas++;
        }
        
        if (arrobas > 1)
            return false;
        return true;
    }

    private string TelefoneFormatado(string telefone)
    {
        string ddd = telefone.Substring(0, 2);
        string parte1 = telefone.Substring(2, 5);
        string parte2 = telefone.Substring(7, 4);
        
        return $"({ddd}) {parte1}-{parte2}";
    }
}