# 🎓 Cálculo de Média - Encapsulamento em C#

Este é um projeto de estudo desenvolvido em **C#** focado em demonstrar os conceitos práticos de Programação Orientada a Objetos (POO), especificamente o **Encapsulamento**.

## 🚀 Sobre o Projeto
O programa simula o cálculo da média escolar de um aluno. Ele interage com o usuário no terminal solicitando a entrada de 3 notas, processa o cálculo matemático em segundo plano e exibe a média final formatada.

## 🧠 Conceitos de POO Aplicados
A estrutura do projeto gira em torno da classe `Aluno`, que protege as suas informações de acessos indevidos:

* **Atributos Privados (`private`):** As variáveis `nota1`, `nota2` e `nota3` não podem ser acessadas ou alteradas diretamente de fora da classe.
* **Método Privado (`private`):** A lógica de cálculo no método `media()` é de uso estritamente interno da classe, garantindo que a fórmula não seja modificada acidentalmente.
* **Método Público (`public`):** O método `resultado()` atua como a única "porta de entrada" (interface) para o usuário, responsável por receber os dados e exibir a saída final.

## 🛠️ Tecnologias Utilizadas
* C# 
* .NET Console App

## 💻 Como Executar
1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone este repositório no seu computador:
   ```bash
   git clone [https://github.com/NatBaracho/encapsulamento.git](https://github.com/NatBaracho/encapsulamento.git)
