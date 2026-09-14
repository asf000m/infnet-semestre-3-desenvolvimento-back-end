Console.WriteLine("Informe uma nota de 0 a 10:");
int nota = int.Parse(Console.ReadLine());

String classificacao;

if (nota < 0 || nota > 10)
    classificacao = "nota inválida";
else if (nota <=4)
    classificacao = "insuficiente";
else if (nota <= 6)
    classificacao = "regular";
else if (nota <= 8)
    classificacao = "bom";
else
    classificacao = "excelente";

Console.WriteLine($"Classificação: {classificacao}");