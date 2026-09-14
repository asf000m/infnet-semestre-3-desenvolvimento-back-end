// Área e Perímetro
// Leia base e altura e calcule área e perímetro do retângulo.

Console.WriteLine("Informe a base e depois a altura:");
float base_retangulo = float.Parse(Console.ReadLine());
float altura = float.Parse(Console.ReadLine());

float area = base_retangulo * altura;
float perimetro = 2 * base_retangulo + 2 * altura;

Console.WriteLine($"Área: {area}\nPerímetro: {perimetro}");
