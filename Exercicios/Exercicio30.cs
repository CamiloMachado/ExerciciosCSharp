// Faça um programa para imprimir uma tabuada.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio30 {

        public static void Executar() {
            // Laço do multiplicador
            for (int i = 1; i < 11; i++) {
                Console.WriteLine("Taboada do {0}", i);
                // Laço do multiplicando
                for (int j = 1; j < 11; j++) {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("");
            }
        }
    }
}
