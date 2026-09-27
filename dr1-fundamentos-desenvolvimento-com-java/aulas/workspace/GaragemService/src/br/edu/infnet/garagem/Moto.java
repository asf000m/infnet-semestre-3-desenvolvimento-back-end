package br.edu.infnet.garagem;

public class Moto extends Veiculo {

    private int cilindradas;
    
    // Constructors
    public Moto(String placa, String marca, int ano, int cilindradas) {
        super(placa, marca, ano);
        this.cilindradas = cilindradas;
    }

    // Methods
    @Override 
    public double calcularCustoManutencao() {
        return cilindradas + 300;
    }

    @Override
    public void exibirResumo() {
        System.out.printf("Moto: ");
        super.exibirResumo();
        System.out.printf(" - %s\n", cilindradas);
    }
}
