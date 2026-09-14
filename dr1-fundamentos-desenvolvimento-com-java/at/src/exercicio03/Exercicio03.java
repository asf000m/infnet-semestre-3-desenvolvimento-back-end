package exercicio03;

import java.util.Scanner;

public class Exercicio03 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Informe o valor do salário bruto mensal: R$ ");
        double salarioBrutoMensal = sc.nextDouble();

        double salarioBrutoAnual = 13 * salarioBrutoMensal;
        double impostoRenda;

        if (salarioBrutoAnual <= 22_847.76)
            impostoRenda = 0;
        else if (salarioBrutoAnual <= 33_919.8)
            impostoRenda = salarioBrutoAnual * 0.075;
        else if (salarioBrutoAnual <= 45_012.6)
            impostoRenda = salarioBrutoAnual * 0.15;
        else
            impostoRenda = salarioBrutoAnual * 0.275;

        double salarioLiquidoAnual = salarioBrutoAnual - impostoRenda;

        System.out.printf("Imposto de renda: R$ %.2f\n", impostoRenda);
        System.out.printf("Salário líquido anual: R$ %.2f\n", salarioLiquidoAnual);

        sc.close();
    }
}
