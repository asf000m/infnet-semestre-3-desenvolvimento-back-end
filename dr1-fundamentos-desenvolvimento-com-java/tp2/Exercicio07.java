
import java.util.Scanner;

public class Exercicio07 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double FAIXA_1_INSS = 1621.0, FAIXA_2_INSS = 2902.84;
        double FAIXA_3_INSS = 4354.27, FAIXA_4_INSS = 8475.55;

        System.out.println("Informe seu salário bruto:");
        double salarioBruto = sc.nextDouble();

        // Cálculo do desconto de contribuição do INSS.
        double descontoInss;
        
        if (salarioBruto <= FAIXA_1_INSS)
            descontoInss = salarioBruto * 0.075;
        
        else if (salarioBruto <= FAIXA_2_INSS)
            descontoInss = salarioBruto * 0.09 - 24.32;

        else if (salarioBruto <= FAIXA_3_INSS)
            descontoInss = salarioBruto * 0.12 - 111.4;

        else if (salarioBruto <= FAIXA_4_INSS)
            descontoInss = salarioBruto * 0.14 - 198.49;

        else
            descontoInss = 988.09;

        descontoInss = Math.round(descontoInss);

        double salarioMenosInss = salarioBruto - descontoInss;
        salarioMenosInss = Math.round(salarioMenosInss);

        double FAIXA_1_IRPF = 2428.8, FAIXA_2_IRPF = 2826.65;
        double FAIXA_3_IRPF = 3751.05, FAIXA_4_IRPF = 4664.68;

        // Cálculo do desconto de imposto de renda.
        double descontoIrpf;

        if (salarioMenosInss <= FAIXA_1_IRPF)
            descontoIrpf = 0;

        else if (salarioMenosInss <= FAIXA_2_IRPF)
            descontoIrpf = salarioMenosInss * 0.075 - 182.16;

        else if (salarioMenosInss <= FAIXA_3_IRPF)
            descontoIrpf = salarioMenosInss * 0.15 - 384.16;

        else if (salarioMenosInss <= FAIXA_4_IRPF)
            descontoIrpf = salarioMenosInss * 0.225 - 675.49;

        else
            descontoIrpf = salarioMenosInss * 0.275 - 908.73;

        double salarioLiquido = salarioMenosInss - descontoIrpf;
        salarioLiquido = Math.round(salarioLiquido);

        System.out.println("Salário bruto: " + salarioBruto);
        System.out.println("Salário menos INSS: " + salarioMenosInss);
        System.out.println("Salário líquido: " + salarioLiquido);

        sc.close();
    }
}
