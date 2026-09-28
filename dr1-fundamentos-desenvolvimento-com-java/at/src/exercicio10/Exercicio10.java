package exercicio10;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Exercicio10 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        final int QTD_COMPRAS = 3;

        String produto;
        int quantidade;
        double precoUnitario;

        try {
            FileWriter fileWriter = new FileWriter("compras.txt");
            BufferedWriter writer = new BufferedWriter(fileWriter);
            writer.write("COMPRAS CADASTRADAS\n\n");
    
            System.out.println("==== CADASTRO DE COMPRAS ====\n");

            for (int i = 0; i < QTD_COMPRAS; i++) {
                
                System.out.println("Informe os dados da compra abaixo (" + (i + 1) + "/" + QTD_COMPRAS + "):");
                
                System.out.print("Produto: ");
                produto = sc.nextLine();
                System.out.print("Quantidade: ");
                quantidade = sc.nextInt();
                System.out.print("Preço unitário: ");
                precoUnitario = sc.nextDouble();
                
                sc.nextLine(); // Limpa buffer.
                System.out.println();
                
                writer.write(
                    "Produto: " + produto + "\n" +
                    "Quantidade: " + quantidade + "\n" + 
                    "Preço unitário: " + precoUnitario + "\n"
                );
                writer.newLine();
            }

            System.out.println("-- Cadastro finalizado. --");
            writer.close();
        
        } 
        catch (IOException e) {
            System.out.println("-- Erro: Falha ao escrever o arquivo. --");
        } 
        catch (InputMismatchException e) {
            System.out.println("-- Erro: Caracteres inválidos digitados. --");
        }

        sc.close();
    }
}
