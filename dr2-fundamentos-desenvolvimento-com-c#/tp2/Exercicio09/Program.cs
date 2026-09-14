Console.WriteLine("Informe o salário bruto:");
double salarioBruto = double.Parse(Console.ReadLine());

double descontoInss;

if (salarioBruto <= 1621)
    descontoInss = salarioBruto * 0.075;
else if (salarioBruto <= 2902.84)
    descontoInss = salarioBruto * 0.09 - 24.32;
else if (salarioBruto <= 4354.27)
    descontoInss = salarioBruto * 0.12 - 111.4;
else if (salarioBruto <= 8475.55)
    descontoInss = salarioBruto * 0.14 - 198.49;
else
    descontoInss = 988.09;

descontoInss = Math.Round(descontoInss, 2);

double salarioMenosInss = salarioBruto - descontoInss;
salarioMenosInss = Math.Round(salarioMenosInss, 2);

double descontoIrpf;

if (salarioMenosInss <= 2428.8)
    descontoIrpf = 0;
else if (salarioMenosInss <= 2826.65)
    descontoIrpf = salarioMenosInss * 0.075 - 182.16;
else if (salarioMenosInss <= 3751.05)
    descontoIrpf = salarioMenosInss * 0.15 - 384.16;
else if (salarioMenosInss <= 4664.68)
    descontoIrpf = salarioMenosInss * 0.225 - 675.49;
else
    descontoIrpf = salarioMenosInss * 0.275 - 908.73;

double salarioLiquido = salarioMenosInss - descontoIrpf;
salarioLiquido = Math.Round(salarioLiquido, 2);

Console.WriteLine($"Salário bruto: {salarioBruto}\nSalário menos INSS: {salarioMenosInss}\nSalário líquido: {salarioLiquido}");