package br.edu.infnet.garagem;

import br.edu.infnet.garagem.model.*;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class GaragemArquivosApp {
    public static void main(String[] args) {

        Veiculo[] veiculos = new Veiculo[10];

        int idx = 0;
        
        try {
            try {
                FileReader file = new FileReader("veiculos.csv");
                BufferedReader leitura = new BufferedReader(file);

                String linha = null;
                linha = leitura.readLine();
                
                while (linha != null) {
                    try {
                        
                        String[] campos = linha.split(";");
                        String tipoVeiculo = campos[0];
                        String placaVeiculo = campos[1];
                        String marca = campos[2];
                        int ano = Integer.parseInt(campos[3]);
                        
                        Veiculo veiculo;

                        switch (tipoVeiculo) {
                            case "CR":
                                int portas = Integer.parseInt(campos[4]);
                                veiculo = new Carro(
                                    placaVeiculo, marca, ano, portas
                                );
                                break;
                            
                            case "MT":
                                int cilindradas = Integer.parseInt(campos[4]);
                                veiculo = new Moto(
                                    placaVeiculo, marca, ano, cilindradas
                                );
                                break;
                            
                            case "CM":
                                double capacidadeCarga = Double.parseDouble(campos[4]);
                                veiculo = new Caminhao(
                                    placaVeiculo, marca, ano, capacidadeCarga
                                );
                                break;
    
                            default:
                                throw new IllegalArgumentException("Tipo de veículo inválido: " + tipoVeiculo);
                        }

                        veiculos[idx++] = veiculo;
    
                    } catch (IllegalArgumentException e) {

                        System.err.println("\nLinha inválida: " + linha);
                        System.out.println("Motivo: " + e.getMessage() + "\n");
                    }
                    
                    linha = leitura.readLine();
                }


                FileWriter fileEscrita = new FileWriter("relatorio-garagem.txt");
                BufferedWriter escrita = new BufferedWriter(fileEscrita);

                escrita.write("RELATÓRIO DA GARAEM");
                escrita.newLine();


                System.out.println("VEÍCULOS PROCESSADOS:");
                for (int i = 0; i < idx; i++) {
                    double custoManutencao = veiculos[i].calcularCustoManutencao();
                    
                    veiculos[i].exibirResumo();
                    
                    System.out.println("Custo de manutenção: R$ " + custoManutencao);
                    System.out.println("--------------------");

                    escrita.write(veiculos[i].toString() + " - " + custoManutencao);
                    escrita.newLine();
                }
                System.out.println("====================");

                
                leitura.close();               
                escrita.close();
            
            } catch (FileNotFoundException e) {
                System.err.println("Impossível abrir o arquivo: " + e.getMessage());
            
            } catch (IOException e) {
                System.err.println("Impossível ler o arquivo: " + e.getMessage());
            }
        
        } finally {
            System.out.println("\nFim do processamento.\n");
        }
    }
}
