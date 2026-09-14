Console.WriteLine("Informe uma data de nascimento:");
Console.Write("Dia: ");
int dia = int.Parse(Console.ReadLine());
Console.Write("Mês: ");
int mes = int.Parse(Console.ReadLine());
Console.Write("Ano: ");
int ano = int.Parse(Console.ReadLine());

DateTime dataNascimento = new(ano, mes, dia);
DateTime dataAtual = DateTime.Now;

int anos = 0;
while (dataNascimento.AddYears(anos + 1) <= dataAtual)
{
    anos++;
}

DateTime dataMaisAnos = dataNascimento.AddYears(anos);
int meses = 0;
while (dataMaisAnos.AddMonths(meses + 1) <= dataAtual)
{
    meses++;
}

DateTime dataMaisMeses = dataMaisAnos.AddMonths(meses);
int dias = 0;
while (dataMaisMeses.AddDays(dias + 1) <= dataAtual)
{
    dias++;
}

Console.WriteLine($"{anos} anos, {meses} meses e {dias} dias");
