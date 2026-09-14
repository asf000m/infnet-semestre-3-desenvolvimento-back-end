namespace Comando_switch;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entre com uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Novo");
                break;
            case 2:
                Console.WriteLine("Abrir");
                break;
            case 3:
                Console.WriteLine("Salvar");
                break;
            default:
                Console.WriteLine("Erro: Opção inválida");
                break;
        }
    }
}
