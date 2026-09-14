package exercicio06;

public class Exercicio06 {
    public static void main(String[] args) {
        Veiculo polo = new Veiculo();
        polo.placa = "ABC1D23";
        polo.modelo = "Polo 1.0 TSI Highline";
        polo.anoFabricacao = 2025;
        polo.quilometragem = 40_400.9;

        polo.exibirDetalhes();
        polo.registrarViagem(230);
        polo.exibirDetalhes();

        Veiculo strada = new Veiculo();
        strada.placa = "WXY0Z98";
        strada.modelo = "Strada Volcano CD 1.3 AT";
        strada.anoFabricacao = 2026;
        strada.quilometragem = 20_450.23;
        
        strada.exibirDetalhes();
        strada.registrarViagem(20);
        strada.exibirDetalhes();
        strada.registrarViagem(19);
        strada.exibirDetalhes();
    }
}


class Veiculo {
    String placa;
    String modelo;
    int anoFabricacao;
    double quilometragem;


    public void exibirDetalhes() {
        System.out.printf("Modelo: %s\nAno de Fabricação: %d\n", modelo, anoFabricacao);
        System.out.printf("Placa: %s\nQuilometragem: %f\n", anoFabricacao, quilometragem);
    }

    public void registrarViagem(double km) {
        quilometragem += km;
    }
}