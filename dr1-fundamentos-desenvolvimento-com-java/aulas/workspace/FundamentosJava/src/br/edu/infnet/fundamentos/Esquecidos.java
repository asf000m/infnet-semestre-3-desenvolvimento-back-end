package br.edu.infnet.fundamentos;

import java.util.Scanner;

public class Esquecidos {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String nome;
        
        do { 
            System.out.println("Informe o nome:");
            nome = sc.nextLine();
            
        } while (nome.isBlank());
        
        System.out.println("Nome: " + nome);

        
        final double NOTA_APROVACAO = 7;
        double notaAluno = 6;

        if (notaAluno > NOTA_APROVACAO) {
            System.out.println("aprovado");
        } else {
            System.out.println("reprovado");
        }

        sc.close();
    }
}
