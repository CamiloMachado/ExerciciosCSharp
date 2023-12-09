// Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio35 {

        public static void Executar() {
            // Laço para contar até 100
            for (int i = 1; i <= 100; i++) {
                // Teste para verificar se o valor na variável i é múltiplo de 10
                if (i % 10 == 0) {
                    Console.WriteLine($"{i} é múltiplo de 10!");
                } else {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
