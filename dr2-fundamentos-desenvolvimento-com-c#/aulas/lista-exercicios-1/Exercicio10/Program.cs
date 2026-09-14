// Cálculo de Desconto
// Leia valor do produto e percentual de desconto e calcule desconto e valor final.


Console.WriteLine("Informe o valor do produto e o percentual de desconto:");
double valor = double.Parse(Console.ReadLine());
double percentual = double.Parse(Console.ReadLine());

double desconto = valor * percentual / 100;
double valorFinal = valor - desconto;

Console.WriteLine($"Valor final: R$ {valorFinal}");
