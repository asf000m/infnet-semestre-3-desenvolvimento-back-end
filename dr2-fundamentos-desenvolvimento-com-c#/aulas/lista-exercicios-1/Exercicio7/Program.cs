// Conversor de idade
// Converta idade em anos para meses e dias (12 meses, 365 dias).


Console.WriteLine("Informe uma idade em anos:");
int idade = int.Parse(Console.ReadLine());

int meses = idade * 12;
int dias = idade * 360;

Console.WriteLine($"Idade em meses: {meses}\nIdade em dias: {dias}");