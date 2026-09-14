package exercicio04;

import java.util.Scanner;

public class Exercicio04 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        final double JUROS_MENSAL = 3;
        int qtdParcelas;
        boolean qtdValida;


        System.out.print("Informe o nome do cliente: ");
        String nome = sc.nextLine();

        System.out.print("Informe o valor do empréstimo: R$ ");
        double emprestimo = sc.nextDouble();

        do { 
            System.out.print("Quantidade de parcelas a pagar (6 a 48): ");
            qtdParcelas = sc.nextInt();
            qtdValida = qtdParcelas >= 6 && qtdParcelas <= 48;

            if (!qtdValida)
                System.out.println("Quantidade inválida.");
        
        } while (!qtdValida);

        double montante = emprestimo * (1 + (JUROS_MENSAL / 100) * qtdParcelas);
        double valorParcelas = montante / qtdParcelas;

        System.out.printf("Valor total a ser pago: R$ %.2f\n", montante);
        System.out.printf("Valor mensal da parcela: R$ %.2f\n", valorParcelas);

        sc.close();
    }
}
