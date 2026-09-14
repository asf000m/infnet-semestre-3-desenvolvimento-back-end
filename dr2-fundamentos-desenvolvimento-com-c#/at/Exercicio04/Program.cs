namespace Exercicio04;

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
        DateTime dataNascimento = new(anoNascimento, mesNascimento, diaNascimento);
        
        // Determina a data atual.
        DateTime dataAtual = DateTime.Today;
        int diaAtual = dataAtual.Day;
        int mesAtual = dataAtual.Month;
        int anoAtual = dataAtual.Year;

        // Determina a próxima data de nascimento.
        int diaProximoAniversario = 0;
        int mesProximoAniversario = 0;
        int anoProximoAniversario = 0;

        if (mesAtual > mesNascimento)
        {
            anoProximoAniversario = anoAtual + 1;
            mesProximoAniversario = mesNascimento;
            diaProximoAniversario = diaNascimento;
        }
        else if (mesAtual < mesNascimento)
        {
            anoProximoAniversario = anoAtual;
            mesProximoAniversario = mesNascimento;
            diaProximoAniversario = diaNascimento;
        }
        else
        {
            if (diaAtual >= diaNascimento)
                anoProximoAniversario = anoAtual + 1;
            else
                anoProximoAniversario = anoAtual;

            mesProximoAniversario = mesNascimento;
            diaProximoAniversario = diaNascimento;
        }

        int diasTotais = 0;
        
        // Calcula os dias entre os anos inteiros da data atual até a data do 
        // próximo aniversário.
        for (int ano = anoAtual + 1; ano < anoProximoAniversario; ano++)
            diasTotais += diasDoAno(ano);

        // Calcula os dias entre o mês seguinte do mês da data atual até o 
        // último dia do ano atual.
        if (anoAtual < anoProximoAniversario)
        {
            for (int mes = mesAtual + 1; mes <= 12; mes++)
                diasTotais += diasDoMes(mes, anoAtual);

            // Calcula os dias entre janeiro do ano do próximo aniversário até o
            // mês do aniversário.
            for (int mes = 1; mes < mesProximoAniversario; mes++)
                diasTotais += diasDoMes(mes, anoProximoAniversario);
        }
        else
        {
            for (int mes = mesAtual + 1; mes < mesProximoAniversario; mes++)
                diasTotais += diasDoMes(mes, anoAtual);
        }

        if (mesAtual == mesProximoAniversario && anoAtual == anoProximoAniversario)
            diasTotais = diaProximoAniversario - diaAtual;
        else
        {
            // Soma ao total de dias a diferenta entre o dia da data atual até o 
            // final do mês atual.
            diasTotais += diasDoMes(mesAtual, anoAtual) - diaAtual;
            // Soma os dias restantes da data de aniversário.
            diasTotais += diaProximoAniversario;
        }

        Console.WriteLine($"Dias totais até o próximo aniversário: {diasTotais}");
        if (diasTotais < 7)
            Console.WriteLine($"Prepare a festa! Faltam menos de 7 dias!");
    }


    // Methods
    public static bool anoBissexto(int ano)
    {
        return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
    }

    public static int diasDoAno(int ano)
    {
        return anoBissexto(ano) ? 366 : 365;
    }

    public static int diasDoMes(int mes, int ano)
    {
        switch (mes)
        {
            case 1: case 3: case 5:
            case 7: case 8: case 10:
            case 12:
                return 31;
            case 4: case 6: case 9:
            case 11:
                return 30;
            case 2:
                if (anoBissexto(ano))
                    return 29;
                else
                    return 28;
        }
        
        return 0;
    }
}
