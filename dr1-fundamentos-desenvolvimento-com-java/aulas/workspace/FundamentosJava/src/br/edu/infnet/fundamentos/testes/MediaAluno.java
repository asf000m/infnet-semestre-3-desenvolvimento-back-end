package br.edu.infnet.fundamentos.testes;

import br.edu.infnet.fundamentos.model.Aluno;
import java.util.Scanner;

public class MediaAluno {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        System.out.print("Informe o seu nome: ");
        String nome = sc.nextLine();
        
        System.out.print("Informe a nota do TP1: ");
        double notaTP1 = sc.nextDouble();
        
        System.out.print("Informe a nota do TP2: ");
        double notaTP2 = sc.nextDouble();
        
        System.out.print("Informe a nota do TP3: ");
        double notaTP3 = sc.nextDouble();
        
        Aluno aluno = new Aluno(nome, notaTP1, notaTP2, notaTP3);
        aluno.imprimir();
        
        sc.close();
    }
}
