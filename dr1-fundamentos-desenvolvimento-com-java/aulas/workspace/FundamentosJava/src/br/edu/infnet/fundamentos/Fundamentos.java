package br.edu.infnet.fundamentos;

public class Fundamentos {
    public static void main(String[] args) {
        for (int i = 0; i < args.length; i++) {
            System.out.println(args[i]);
        }

        for (String nome : args) {
            System.out.println(nome);
        }
    }
}
