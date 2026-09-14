public class Exercicio01 {
    public static void main(String[] args) {
        /*
        Uma classe é um modelo que define a forma de um objeto da realidade.
        Nela são definidos os dados e ações que fazem parte do objeto. 
        
        Por exemplo, uma classe Animal pode ser criada para criar objetos que
        representam um animal, com os dados sendo as caracteríticas gerais de
        todos os animais e suas ações são os metodos que manipulam esses dados.
        */

        // Criação de um novo objeto e armazenamento em uma variável.
        Animal gato = new Animal();

        // Preenchimento dos atributos do objeto.
        gato.vertebrado = true;
        gato.genero = "Felis";
        gato.especie = "catus";
        gato.grupo = "mamífero";

        // Execução de um método.
        System.out.println(gato.nomeCientifico().toUpperCase());
        gato.imprimir();
    }
}

class Animal {
    // Definição de atributos da classe.
    boolean vertebrado;
    String genero;
    String especie;
    String grupo;


    // Definição de métodos.
    void imprimir() {
        String vertebradoStr = vertebrado ? "sim" : "não";
        System.out.printf("Animal: %s %s\nÉ vertebrado: %s\nGrupo: %s",
            genero, especie, vertebradoStr, grupo
        );
    }

    String nomeCientifico() {
        return genero + " " + especie;
    }
}