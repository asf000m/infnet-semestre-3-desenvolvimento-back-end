package br.edu.infnet.garagem;

public class Carro extends Veiculo {

    private int numeroPortas;

    
    // Constructors
    public Carro(String placa, String marca, int ano, int numeroPortas) {
        super(placa, marca, ano);
        this.numeroPortas = numeroPortas;
    }

    // Methods
    @Override 
    public void exibirResumo() {
        System.out.printf("Carro: ");
        super.exibirResumo();
        System.out.printf(" - %s\n", numeroPortas);
    }

}
