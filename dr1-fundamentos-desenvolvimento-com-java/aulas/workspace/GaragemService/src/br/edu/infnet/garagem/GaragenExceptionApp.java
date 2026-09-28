package br.edu.infnet.garagem;

import br.edu.infnet.garagem.model.Caminhao;
import br.edu.infnet.garagem.model.Carro;
import br.edu.infnet.garagem.model.Moto;

public class GaragenExceptionApp {
    public static void main(String[] args) {
        
        try {
            
            try {
                Carro toyota = new Carro("ABC1D23", "Toyota", 2027, 4);
                toyota.exibirResumo();
            } catch (IllegalArgumentException e) {
                System.err.println("Não foi possível criar o veículo.\n" + e.getMessage());
            }

            try {
                Carro fiat = new Carro("ABC2D46", "Fiat", 1848, 4);
                fiat.exibirResumo();
            } catch (IllegalArgumentException e) {
                System.err.println("Não foi possível criar o veículo.\n" + e.getMessage());
            }

            try {
                Moto yamaha = new Moto("XYZ9A87", "Yamaha", 2025, 160);
                yamaha.exibirResumo();
            } catch (IllegalArgumentException e) {
                System.err.println("Não foi possível criar o veículo.\n" + e.getMessage());
            }

            try {
                Moto honda = new Moto("XYZ1A23", "Honda", 2024, 190);
                honda.exibirResumo();
            } catch (IllegalArgumentException e) {
                System.err.println("Não foi possível criar o veículo.\n" + e.getMessage());
            }

            try {
                Caminhao volvo = new Caminhao("KLM1N23", "Volvo", 2021, 18.5);
                volvo.exibirResumo();
            } catch (IllegalArgumentException e) {
                System.err.println("Não foi possível criar o veículo.\n" + e.getMessage());
            }
        
        } finally {
            System.out.println("\nFim do programa.\n");
        }
    }
}
