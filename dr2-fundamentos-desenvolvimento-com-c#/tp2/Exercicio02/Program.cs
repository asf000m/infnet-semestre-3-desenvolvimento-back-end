Console.WriteLine("Informe uma data de nascimento:");
Console.Write("Dia: ");
int dia = int.Parse(Console.ReadLine());
Console.Write("Mês: ");
int mes = int.Parse(Console.ReadLine());
Console.Write("Ano: ");
int ano = int.Parse(Console.ReadLine());

DateTime dataNascimento = new(ano, mes, dia);
DateTime proxAniversario = new(DateTime.Now.Year + 1, mes, dia);

Console.WriteLine(dataNascimento);
Console.WriteLine(proxAniversario);