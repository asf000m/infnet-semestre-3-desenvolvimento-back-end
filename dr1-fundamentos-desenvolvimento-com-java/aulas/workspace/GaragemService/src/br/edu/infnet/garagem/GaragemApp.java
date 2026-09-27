package br.edu.infnet.garagem;

public class GaragemApp {
    public static void main(String[] args) {
        
        Carro[] carros = new Carro[2];
        carros[0] = new Carro("ABC1D23", "Toyota", 2025, 4);
        carros[1] = new Carro("ABC2D46", "Fiat", 2025, 4);

        Moto[] motos = new Moto[2];
        motos[0] = new Moto("XYZ9A87", "Yamaha", 2025, 160);
        motos[1] = new Moto("XYZ1A23", "Yamaha", 2024, 190);
        
        Maquina maquina = new Maquina("Lavadora");
        // maquina.realizarRevisao();

        Carro carro = new Carro("GHI456", "Kiwi", 2040, 2);
        // carro.realizarRevisao();
        

        Veiculo[] veiculos = new Veiculo[6];
        veiculos[0] = carros[0];
        veiculos[1] = motos[0];
        veiculos[2] = carros[1];
        veiculos[3] = motos[1];
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
