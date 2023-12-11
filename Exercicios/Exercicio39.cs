// Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar, e se é positivo ou
// negativo.
// O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".

using System.Xml;

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio39 {

        public static void Executar() {
            // Variável terminar o programa
            char parar = 'n';

            while (parar == 'n' || parar == 'N') {
                // Solicita o número ao usuário
                Console.Write("Digite um número: ");
                _ = int.TryParse(Console.ReadLine(), out int num);

                if (num % 2 != 0) {
                    Console.WriteLine($"\nO número {num} é ímpar!");
                } else {
                    Console.WriteLine($"\nO número {num} é Par!");
                }

                if (num >= 0) {
                    Console.WriteLine($"O número {num} é Positivo!");
                } else {
                    Console.WriteLine($"O número {num} é Negativo!");
                }

                // Pergunta se o usuário deseja encerrar o programa
                Console.Write("\nDeseja encerrar o programa?(S/N): ");
                _ = char.TryParse(Console.ReadLine(), out parar);
                Console.WriteLine("");
            }
        }
    }
}
