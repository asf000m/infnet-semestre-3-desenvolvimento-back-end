package exercicio07;

import java.util.Scanner;

public class Exercicio07 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        Aluno aluno01 = new Aluno();
        
        System.out.print("Informe o nome do aluno: ");
        aluno01.nome = sc.nextLine();

        System.out.print("Informe a matrícula do aluno: ");
        aluno01.matricula = sc.nextInt();

        System.out.println("Informe as três notas para cálculo da média:");
        aluno01.nota1 = sc.nextDouble();
        aluno01.nota2 = sc.nextDouble();
        aluno01.nota3 = sc.nextDouble();

        System.out.print("Situação do aluno: ");
        aluno01.verificarAprovacao();
    }
}


class Aluno {
    String nome;
    int matricula;
    double nota1;
    double nota2;
    double nota3;


    private double calcularMedia() {
        return (nota1 + nota2 + nota3) / 3;
    }

    public void verificarAprovacao() {
        if (calcularMedia() >= 7)
            System.out.println("Aprovado");
        else
            System.out.println("Reprovado");
    }
}