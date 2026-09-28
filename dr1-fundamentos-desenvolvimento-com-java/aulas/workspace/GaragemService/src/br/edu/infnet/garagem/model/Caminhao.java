package br.edu.infnet.garagem.model;

public class Caminhao extends Veiculo {

    // Attributes
    private double capacidadeCarga;

    // Constructors
    public Caminhao(String placa, String marca, int ano, double capacidadeCarga) {
        super(placa, marca, ano);
        this.capacidadeCarga = capacidadeCarga;
    }

    // Methods
    @Override
    public double calcularCustoManutencao() {
        return (capacidadeCarga * 100) + 1500;
    }

    @Override 
    public void exibirResumo() {
        System.out.printf("Caminhão: ");
        super.exibirResumo();
        System.out.printf(" - %.2f\n", capacidadeCarga);
    }  
}
