public class Exercicio12 {
    public static void main(String[] args) {
        Circulo3 circulo = new Circulo3();
        circulo.raio = 3.0;
        double areaCirculo = circulo.calcularArea();

        Esfera3 esfera = new Esfera3();
        esfera.raio = 5.0;
        double volumeEsfera = esfera.calcularVolume();

        System.out.printf("Área do círculo: %.2f\n", areaCirculo);
        System.out.printf("Volume da esfera: %.2f\n", volumeEsfera);
    }
}


// O raio é a variável que permite calcular o perímetro, a área e o volume das 
// duas figuras geométricas.

class Circulo3 {
    double raio;


    public double calcularArea() {
        return Math.PI * (raio * raio);
    }
}


class Esfera3 {
    double raio;


    public double calcularVolume() {
        return (4.0 / 3.0) * Math.PI * (raio * raio * raio);
    }
}