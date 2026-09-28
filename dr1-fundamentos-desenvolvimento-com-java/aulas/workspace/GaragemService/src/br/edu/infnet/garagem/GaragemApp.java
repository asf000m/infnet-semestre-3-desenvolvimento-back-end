package br.edu.infnet.garagem;

import br.edu.infnet.garagem.interfaces.Revisto;
import br.edu.infnet.garagem.model.Caminhao;
import br.edu.infnet.garagem.model.Carro;
import br.edu.infnet.garagem.model.Maquina;
import br.edu.infnet.garagem.model.Moto;
import br.edu.infnet.garagem.model.Veiculo;

public class GaragemApp {
    public static void main(String[] args) {
        
        Maquina maquina = new Maquina("Lavadora");
        // maquina.realizarRevisao();

        Carro carro = new Carro("GHI456", "Kiwi", 2040, 2);
        // carro.realizarRevisao();
        
        Veiculo[] veiculos = new Veiculo[6];
        
        veiculos[0] = new Carro("ABC1D23", "Toyota", 2025, 4);
        veiculos[1] = new Carro("ABC2D46", "Fiat", 2025, 4);
        veiculos[2] = new Moto("XYZ9A87", "Yamaha", 2025, 160);
        veiculos[3] = new Moto("XYZ1A23", "Yamaha", 2024, 190);
        veiculos[4] = new Caminhao("KLM1N23", "Volvo", 2021, 18.5);
        veiculos[5] = carro;
        
        for (Veiculo v : veiculos) {
            v.exibirResumo();
            
            double custoManutencao = v.calcularCustoManutencao();
            
            System.out.printf("Manutenção estimada: R$ %.2f\n", custoManutencao);
            System.out.println("------------------------------");
        }
        
        Revisto[] revistos = {maquina, carro};

        for (Revisto r : revistos) {
            r.realizarRevisao();
        }
    }
}
