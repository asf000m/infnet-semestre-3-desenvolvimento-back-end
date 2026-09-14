# Fundamentos de Desenvolvimento com C# [26E3_2]

---

## Parte 1: Preparar Ambiente para Desenvolvimento Local com C# e .NET

---

### Exercício 1: Criando e Executando seu Primeiro Programa

Enunciado:

* Instale e configure o Visual Studio Community 2022.
* Crie um novo projeto do tipo Console Application em C#.
  * No método Main(), escreva um programa que imprima no terminal:
  
    ```console
    Olá, meu nome é [Seu Nome]!
    Nasci em [sua data de nascimento] e estou aprendendo C#!
    ```

* Compile e execute o programa.

Observações:

* Envie uma captura de tela do código no Visual Studio.
* Envie uma captura de tela da saída do programa.

Critérios de Avaliação:

* Configuração correta do ambiente de desenvolvimento.
* Uso correto da sintaxe do C#.
* Programa funcionando conforme esperado.

---

## Parte 2: Escrever Programas em C# Usando seus Elementos Básicos

---

### Exercício 2: Manipulação de Strings - Cifrador de Nome

Enunciado:

Crie um programa que receba seu nome completo e desloque cada letra duas posições para frente no alfabeto.

* Entrada: "Carlos Silva"
* Saída esperada: "Ectnquu Ukngxc"

Observações:

* Utilize arrays e manipulação de caracteres.
* Ignore espaços e acentos no deslocamento.
* Não utilize bibliotecas de criptografia prontas.

Critérios de Avaliação:

* Implementação correta do deslocamento.
* Uso correto de arrays e manipulação de strings.
* Código organizado e comentado.

### Exercício 3: Calculadora de Operações Matemáticas

Enunciado:

Crie um programa que solicite dois números e peça ao usuário para escolher uma operação matemática:

* Soma
* Subtração
* Multiplicação
* Divisão

O programa deve calcular e exibir o resultado da operação escolhida.

Observações:

* O programa deve aceitar apenas números válidos.
* A operação deve ser escolhida digitando 1, 2, 3 ou 4.
* Evite divisões por zero!

Critérios de Avaliação:

* Implementação correta da lógica matemática.
* Validação de entrada funcionando corretamente.
* Código organizado e comentado.

### Exercício 4: Manipulação de Datas - Dias até o Próximo Aniversário

Enunciado:

Crie um programa que peça sua data de nascimento e informe quantos dias faltam para seu próximo aniversário.

Regras:

* Utilize a classe DateTime.
* Considere anos bissextos.
* Se faltar menos de 7 dias, exibir uma mensagem especial.

Critérios de Avaliação:

* Manipulação correta de datas.
* Cálculo correto do intervalo de dias.
* Exibição da saída formatada corretamente.

### Exercício 5: Tempo Restante para Conclusão do Curso - Diferença Entre Datas

Contexto:

Como estudante do Instituto Infnet que deseja acompanhar quanto tempo falta para sua formatura. Para isso, você decidiu criar um programa que calcula quantos anos, meses e dias restam até a data prevista para a conclusão do curso.

No ambiente acadêmico, a manipulação correta de datas é essencial para organizar prazos de disciplinas, entrega de TCCs, estágios obrigatórios e colação de grau. Este exercício ajudará a desenvolver habilidades fundamentais para a criação de sistemas acadêmicos, como portais do aluno e gerenciadores de calendário acadêmico.

Enunciado:

Implemente um programa que peça ao usuário a data atual e compare com a data prevista de sua formatura (definida manualmente no código). O programa deve exibir:

Saídas esperadas:

* Quanto tempo falta para a formatura (anos, meses e dias).
* Se faltar menos de 6 meses, exibir a mensagem especial: A reta final chegou! Prepare-se para a formatura!
* Se a data de formatura já tiver passado, exibir a mensagem: Parabéns! Você já deveria estar formado!

Regras:

* O aluno deve definir manualmente sua data prevista de formatura no código.
* O programa deve pedir a data atual (input do usuário).
* Utilize a classe DateTime para manipular as datas corretamente.
* Evitar erros com datas inválidas (exemplo: usuário inserindo datas futuras como data atual).

Exemplo de Entrada e Saída:

```console
Entrada:
Digite a data atual (dd/MM/yyyy): 10/04/2024

Data de formatura (definida no código):
DateTime dataFormatura = new DateTime(2026, 12, 15);

Saída esperada:
Faltam 2 anos, 8 meses e 5 dias para sua formatura!

Se faltar menos de 6 meses:
Faltam 5 meses e 10 dias para sua formatura!
A reta final chegou! Prepare-se para a formatura!

Se a data de formatura já tiver passado:
Parabéns! Você já deveria estar formado!

Se a data atual for futura:
Erro: A data informada não pode ser no futuro!
```

Critérios de Avaliação:

* Manipulação correta de datas usando DateTime.
* Cálculo correto do tempo restante até a formatura.
* Tratamento adequado para datas inválidas (exemplo: usuário inserindo data futura como data atual).
* Exibição formatada corretamente e código bem estruturado.
