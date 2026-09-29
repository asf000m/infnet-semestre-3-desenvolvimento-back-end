namespace Exercicio05;

class Program
{
    static void Main(string[] args)
    {
        DateTime dataFormatura = new(2028, 01, 01);
        DateTime dataAtual = new(2000, 1, 1);
        bool dataInvalida = true;

        while (dataInvalida)
        {
            Console.Write("Informe a data atual (DD/MM/AAAA): ");
            String dataAtualInput = Console.ReadLine();
            
            string[] dataAtualArray = dataAtualInput.Split("/");
            int diaAtual = int.Parse(dataAtualArray[0]);
            int mesAtual = int.Parse(dataAtualArray[1]);
            int anoAtual = int.Parse(dataAtualArray[2]);
            
            dataAtual = new(anoAtual, mesAtual, diaAtual);
            
            if ((dataFormatura - dataAtual).Days < 0)
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            else
                dataInvalida = false;
        }

        Console.WriteLine($"Data da formatura: {dataFormatura.ToShortDateString()}");

        int anos = dataFormatura.Year - dataAtual.Year;
        int meses = dataFormatura.Month - dataAtual.Month;
        int dias = dataFormatura.Day - dataAtual.Day;

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }
        if (dias < 0)
        {
            meses--;
            dias += 31;
        }

        Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para a formatura.");
        
        if (meses < 6)
            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!"); 
    }
}
