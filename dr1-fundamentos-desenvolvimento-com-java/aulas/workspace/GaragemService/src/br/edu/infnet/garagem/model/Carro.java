package br.edu.infnet.garagem.model;

import br.edu.infnet.garagem.interfaces.Revisto;

public class Carro extends Veiculo implements Revisto {

    private int numeroPortas;

    
    // Constructors
    public Carro(String placa, String marca, int ano, int numeroPortas) {
        super(placa, marca, ano);
        this.numeroPortas = numeroPortas;
    }

    // Methods
    @Override 
    public double calcularCustoManutencao() {
        return (numeroPortas * 50) + 800;
    }

    @Override
    public void exibirResumo() {
        System.out.printf("Carro: ");
        super.exibirResumo();
        System.out.printf(" - %s\n", numeroPortas);
    }

    @Override
    public void realizarRevisao() {
        System.out.println("Realizando revisão do carro!");
    }
}
