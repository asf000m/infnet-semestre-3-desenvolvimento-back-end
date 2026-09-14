Console.WriteLine("Informe a data inicial:");
Console.Write("Dia: ");
int dia1 = int.Parse(Console.ReadLine());
Console.Write("Mês: ");
int mes1 = int.Parse(Console.ReadLine());
Console.Write("Ano: ");
int ano1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a data final:");
Console.Write("Dia: ");
int dia2 = int.Parse(Console.ReadLine());
Console.Write("Mês: ");
int mes2 = int.Parse(Console.ReadLine());
Console.Write("Ano: ");
int ano2 = int.Parse(Console.ReadLine());

DateTime data1 = new(ano1, mes1, dia1);
DateTime data2 = new(ano2, mes2, dia2);

int anos = 0;
while (data1.AddYears(anos + 1) <= data2)
{
    anos++;
}

DateTime dataMaisAnos = data1.AddYears(anos);
int meses = 0;
while (dataMaisAnos.AddMonths(meses + 1) <= data2)
{
    meses++;
}

DateTime dataMaisMeses = dataMaisAnos.AddMonths(meses);
int dias = 0;
while (dataMaisMeses.AddDays(dias + 1) <= data2)
{
    dias++;
}

Console.WriteLine($"{anos} anos, {meses} meses e {dias} dias");
