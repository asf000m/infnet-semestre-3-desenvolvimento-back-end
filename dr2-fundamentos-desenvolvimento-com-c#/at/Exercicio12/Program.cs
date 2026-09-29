namespace Exercicio12;

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

                    try
                    {
                        Contato contato;
                        
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

                    Console.WriteLine("Em qual formato de exibição?");
                    Console.Write(
                        "1 - Markdown\n" +
                        "2 - Tabela\n" +
                        "3 - Texto puro\n" +
                        "> "
                    );
                    int opcaoListar = int.Parse(Console.ReadLine());

                    try
                    {
                        string linha;
                        int contatosCadastrados = File.ReadAllLines(caminhoArquivo).Count();
                        int idxContato = 0;
                        
                        Contato[] contatos = new Contato[contatosCadastrados];
                        
                        using (StreamReader reader = new StreamReader(caminhoArquivo))
                        {
                            while ((linha = reader.ReadLine()) != null)
                            {
                                string[] dados = linha.Trim().Split(",");
                                string nome, telefone, email;

                                if (dados.Length == 3)
                                {
                                    nome = dados[0];
                                    telefone = dados[1];
                                    email = dados[2];
                                    
                                    Contato contato = new Contato(
                                        nome, telefone, email
                                    );

                                    contatos[idxContato++] = contato;
                                }
                            }

                            if (contatosCadastrados == 0)
                                Console.WriteLine("\n-- Erro: Nenhum contato cadastrado. --");
                            else
                                Console.WriteLine();
                                
                                if (opcaoListar == 1)
                                    new MarkdownFormatter().ExibirContatos(contatos);
                                else if (opcaoListar == 2)
                                    new TabelaFormatter().ExibirContatos(contatos);
                                else if (opcaoListar == 3)
                                    new RawTextFormatter().ExibirContatos(contatos);
                                else
                                    throw new ArgumentException(
                                        "-- Erro: Opção inválida. --"
                                    );
                                
                                Console.WriteLine();
                        }

                        Console.WriteLine();
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("\n-- Erro: Arquivo não encontrado. --");
                        Console.WriteLine(e.Message + "\n");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("\n" + e.Message + "\n");
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
        return $"{Nome},{Telefone},{Email}";
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

    public string GetTelefoneFormatado()
    {
        return TelefoneFormatado(Telefone);
    }

    public string GetEmail()
    {
        return Email;
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

public class ContatoFormatter
{
    // Methods
    public virtual void ExibirContatos(Contato[] contatos) {}
}

public class MarkdownFormatter : ContatoFormatter
{
    // Methods
    public override void ExibirContatos(Contato[] contatos)
    {
        Console.WriteLine("## Lista de Contatos");
        
        foreach (Contato contato in contatos)
        {
            if (contato != null)
                Console.WriteLine(
                    $"- **Nome:** {contato.GetNome()}\n" +
                    $"- Telefone: {contato.GetTelefoneFormatado()}\n" +
                    $"- Email: {contato.GetEmail()}"
                );
        }
    }
}

public class TabelaFormatter : ContatoFormatter
{
    // Attributes
    private int TamanhoSeparador = 60;
    private char CharSeparador = '-';
    

    // Methods
    public override void ExibirContatos(Contato[] contatos)
    {
        Separador();
        Cabecalho();
        Separador();
        foreach (Contato contato in contatos)
        {
            if (contato != null)
                Console.WriteLine($"| {contato.ToString()} |");
        }
        Separador();
    }

    private void Separador()
    {
        Console.WriteLine(new string(CharSeparador, TamanhoSeparador));
    }

    private void Cabecalho()
    {
        Console.WriteLine("| Nome | Telefone | Email |");
    }
}

public class RawTextFormatter : ContatoFormatter
{
    // Methods
    public override void ExibirContatos(Contato[] contatos)
    {
        foreach (Contato contato in contatos)
        {
            if (contato != null)
                Console.WriteLine(
                    $"Nome: {contato.GetNome()} | " +
                    $"Telefone: {contato.GetTelefoneFormatado()} | " +
                    $"Email: {contato.GetEmail()}"
                );
        }
    }
}