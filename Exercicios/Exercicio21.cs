using System.Threading.Channels;

namespace ExerciciosCSharp.Exercicios {
    // Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é positivo ou negativo.
    // Pare a execução do programa quando o usuário requisitar.

    internal class Exercicio21 {

        public static void Executar() {
            bool continuar;
            //Estrutura de repetição até que o usuário cancele
            do {
                // Solicitando o valor
                Console.Write("Digite um número: ");
                _ = int.TryParse(Console.ReadLine(), out int num);

                // Válindando se o número é positivo ou negativo
                if (num < 0) {
                    Console.WriteLine("O número é negativo!");
                } else {
                    Console.WriteLine("O número é positivo");
                }

                // verificando se o usuário deseja continuar
                Console.WriteLine("Deseja continuar(s/n): ");
                var opcao = Console.ReadLine();

                if (opcao == "n" || opcao == "N") {
                    continuar = false;
                } else {
                    continuar = true;
                }

                Console.WriteLine("\n");
            } while (continuar);
        }
    }
}
