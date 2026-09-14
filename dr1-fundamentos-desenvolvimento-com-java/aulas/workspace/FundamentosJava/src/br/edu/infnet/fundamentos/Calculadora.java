package br.edu.infnet.fundamentos;

import java.util.Scanner;

public class Calculadora {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int opcao;

        do {
            System.out.println("Calculadora!");
            System.out.println("1 - Somar\n2 - Subtrair");
            System.out.println("3 - Multiplicar\n4 - Dividir");
            System.out.println("5 - Calcular o resto\n9 - Sair");
            System.out.print("Escolha uma opção: ");
    
            opcao = sc.nextInt();

            if (opcao >= 1 && opcao <= 5) {
                System.out.print("Informe o primeiro número: ");
                int primeiroNum = sc.nextInt();
        
                System.out.print("Informe o segundo número: ");
                int segundoNum = sc.nextInt();
                
                int resultado;

                switch (opcao) {
                    case 1:
                        resultado = primeiroNum + segundoNum;
                        System.out.println("Soma: " + resultado);
                        break;
                    case 2:
                        resultado = primeiroNum - segundoNum;
                        System.out.println("Subtração: " + resultado);
                        break;
                    case 3:
                        resultado = primeiroNum * segundoNum;
                        System.out.println("Multiplicação: " + resultado);
                        break;
                    case 4:
                        if (segundoNum != 0) {
                            resultado = primeiroNum / segundoNum;
                            System.out.println("Divisão: " + resultado);
                        } else {
                            System.out.println("Não é possível dividir por zero!");
                        }
                        break;        
                    case 5:
                        if (segundoNum != 0) {
                            resultado = primeiroNum % segundoNum;
                            System.out.println("Resto: " + resultado);
                        } else {
                            System.out.println("Não é possível dividir por zero!");
                        }
                        break;
                    default:
                        break;
                }
            } else if (opcao == 9) {
                System.out.println("Até logo!");
            } else {
                System.out.println("Opção inválida!");
            }
    
        } while (opcao != 9);

        sc.close();
    }
}
