package br.edu.infnet.fundamentos;

import java.util.Scanner;

public class PrimeiroScanner {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
    
        String nome;
        boolean nomeVazio;
    
        do {
            System.out.println("Digite o seu nome: ");
            
            nome = sc.nextLine();
            nomeVazio = nome.isBlank();
            
            if (nomeVazio) {
                System.out.println("O nome não pode ficar vazio!");
            }
        } while (nomeVazio);
    
        System.out.println("Maravilha! Bom te receber, " + nome + "!");

        sc.close();
    }
}
