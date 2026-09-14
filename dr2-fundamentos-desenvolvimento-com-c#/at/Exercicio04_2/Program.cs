namespace Exercicio04_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a data de nascimento (DD/MM/AAAA): ");
        String dataNascimentoInput = Console.ReadLine();
        
        // Determina a data de nascimento.
        String[] dataNascimentoArray = dataNascimentoInput.Split("/");
        int diaNascimento = int.Parse(dataNascimentoArray[0]);
        int mesNascimento = int.Parse(dataNascimentoArray[1]);
        int anoNascimento = int.Parse(dataNascimentoArray[2]);
        
        DateTime dataAtual = DateTime.Today;
        DateTime dataNascimento = new(
            anoNascimento, mesNascimento, diaNascimento
        );
        DateTime proximoAniversario = new(
            dataAtual.Year, dataNascimento.Month, dataNascimento.Day
        );

        if (dataAtual > proximoAniversario)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        int diasTotais = (proximoAniversario - dataAtual).Days;
        Console.WriteLine($"Dias totais até o próximo aniversário: {diasTotais}");
        
        if (diasTotais < 7)
            Console.WriteLine("Prepare a festa! Faltam menos de 7 dias!");
    }
}
