// Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio28 {

        public static void Executar() {
            // Laço para gerar os números de 100 até 200
            for (int i = 100; i < 201; i++) {
                // validar se o número é ímpar
                if (i % 2 != 0) {
                    Console.WriteLine("{0} é ímpar!", i);
                }
            }
        }
    }
}
