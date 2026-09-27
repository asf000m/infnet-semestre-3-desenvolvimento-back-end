package br.edu.infnet.garagem;

public class GaragemApp {
    public static void main(String[] args) {

        
        
        Carro[] carros = new Carro[2];
        carros[0] = new Carro("ABC1D23", "Toyota", 2025, 4);
        carros[1] = new Carro("ABC2D46", "Fiat", 2025, 4);
        
        for (Carro c : carros) {
            c.exibirResumo();
        }

        System.out.println("");
        
        Moto[] motos = new Moto[2];
        motos[0] = new Moto("XYZ9A87", "Yamaha", 2025, 160);
        motos[1] = new Moto("XYZ1A23", "Yamaha", 2024, 190);
        
        for (Moto m : motos) {
            m.exibirResumo();
        }

        System.out.println("");
        
        Veiculo[] veiculos = new Veiculo[5];
        veiculos[0] = carros[0];
        veiculos[1] = motos[0];
        veiculos[2] = carros[1];
        veiculos[3] = motos[1];
        veiculos[4] = new Caminhao("KLM1N23", "Volvo", 2021, 18.5);

        for (Veiculo v : veiculos) {
            if (v instanceof Carro)
                System.out.println("\nCarro");
            else if (v instanceof Moto)
                System.out.println("\nMoto");
            else if (v instanceof Caminhao)
                System.out.println("\nCaminhão");
            else
                System.out.println("\nNada");

            v.exibirResumo();
        }
    }
}
