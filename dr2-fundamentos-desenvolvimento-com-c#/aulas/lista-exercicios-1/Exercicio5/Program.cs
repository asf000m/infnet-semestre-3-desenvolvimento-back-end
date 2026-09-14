// Conversão de Temperatura
// Converta Celsius para Fahrenheit usando F = (C * 9 / 5) + 32.

Console.WriteLine("Informe uma temperatura em graus Celsius:");
float c = float.Parse(Console.ReadLine());

float f = (c * 9 / 5) + 32;

Console.WriteLine($"Temperatura em Fahrenheit: {f}");
