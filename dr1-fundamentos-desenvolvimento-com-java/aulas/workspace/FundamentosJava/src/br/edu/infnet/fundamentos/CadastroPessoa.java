package br.edu.infnet.fundamentos;

import java.util.Scanner;

public class CadastroPessoa {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String nome;
        boolean nomeVazio;
        int idade;
        boolean idadeInvalida;
        double altura;
        boolean alturaInvalida;
        
        do { 
            System.out.print("Nome: ");
            nome = sc.nextLine();

            nomeVazio = nome.isBlank();
            if (nomeVazio) {
                System.out.println("O nome não pode ficar vazio!");
            }
        } while (nomeVazio);

        do { 
            System.out.print("Idade: ");
            idade = sc.nextInt();

            idadeInvalida = idade < 0 || idade > 120;

            if (idadeInvalida) {
                System.out.println("Idade inválida!");
            }
        } while (idadeInvalida);

        do {
            System.out.print("Altura: ");
            altura = sc.nextDouble();

            alturaInvalida = altura < 0 || altura > 3;

            if (alturaInvalida) {
                System.out.println("Altura inválida!");
            }
        } while (alturaInvalida);

        
        System.out.println("Eu sou " + nome + ", tenho " + idade + " anos e " + altura + " de altura!");

        if (idade < 0) {
            System.out.println("Foi impossível definir a faixa etária através da idade informada.");
        } else {
            String faixaEtaria;

            if (idade < 12) {
                faixaEtaria = "criança";
            } else if (idade < 18) {
                faixaEtaria = "adolescente";
            } else if (idade < 60) {
                faixaEtaria = "adulto";
            } else {
                faixaEtaria = "idoso";
            }

            System.out.println("Classificação: " + faixaEtaria);
        }

        sc.close();
    }
}
