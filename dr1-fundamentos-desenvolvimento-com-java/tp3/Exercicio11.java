public class Exercicio11 {
    public static void main(String[] args) {
        
    }
}


// O raio é a variável que permite calcular o perímetro, a área e o volume das 
// duas figuras geométricas.

class Circulo2 {
    double raio;


    public double calcularArea() {
        return Math.PI * (raio * raio);
    }
}


class Esfera2 {
    double raio;


    public double calcularVolume() {
        return (4.0 / 3.0) * Math.PI * (raio * raio * raio);
    }
}