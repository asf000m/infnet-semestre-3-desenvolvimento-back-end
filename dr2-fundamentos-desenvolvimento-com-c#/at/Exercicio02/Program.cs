namespace Exercicio02;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o nome completo: ");
        String nome = Console.ReadLine();

        String novoNome = "";
        char[] nomeChars = nome.ToCharArray();

        foreach (char ch in nomeChars)
        {
            if (ch == ' ')
            {
                novoNome += " ";
            }
            else
            {
                char novoCh = (char) ((int) ch + 2);
                novoNome += novoCh.ToString();
            }
        }

        Console.WriteLine(novoNome);
    }
}
