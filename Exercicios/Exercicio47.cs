// Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo
// e maior que zero.
// Faça um programa para:
// a.ler pelo teclado o vetor;
// b.ler pelo teclado o número X;
// c.dizer quantos números no vetor são maiores que X, menores que X e iguais a X.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio47 {

        public static void Executar() {
            // Criação do vetor e variáveis para guardar as conparações
            uint[] vetor = new uint[10];
            uint maior = 0, menor = 0, igual = 0;

            // Imprime um texto para interação com o usuário
            Console.WriteLine("Favor digite os valores para o vetor!");
            Console.WriteLine("");

            // Laço para que seja digitado os valores para guardar no vetor
            for (int i = 0; i < 10; i++) {
                Console.Write($"Digite o {i + 1}º valor: ");
                _ = uint.TryParse(Console.ReadLine(), out vetor[i]);
            }

            // Solicita um valor que será comparado com os valores do vetor
            Console.WriteLine("");
            Console.Write($"Digite um número: ");
            _ = uint.TryParse(Console.ReadLine(), out uint numX);

            // Percore o vetor e verifica qual é maior, menor e igual e guarda nas variáveis
            foreach (uint num in vetor) {
                if (num > numX) {
                    maior++;
                } else if (num < numX) {
                    menor++;
                } else {
                    igual++;
                }
            }

            // Imprime os valores, maior, menor e igual
            Console.WriteLine("");
            Console.WriteLine($"temos {maior} números no vetor maior do que o número X.");
            Console.WriteLine($"temos {menor} números no vetor menor do que o número X.");
            Console.WriteLine($"temos {igual} números no vetor igual ao número X.");
        }
    }
}
