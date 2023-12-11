// Faça um programa de conversão de base numérica.
// O programa deverá apresentar uma tela de entrada com as seguintes opções:
// 1 – Adição
// 2 – Subtração
// 3 – Multiplicação
// 4 – Divisão

// Informe a opção:
// A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números.
// Em seguida, o programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao
// menu principal.
// Caso a resposta seja ´S´ ou ´s´, deverá voltar ao menu, caso contrário deverá encerrar o programa.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio37 {

        public static void Executar() {
            // Variável para voltar ao menu ou terminar o programa
            char menuPrincipal = 's';

            // Laço para que o programa possa ser repetido caso o usuário deseje fazer outra operação
            while (menuPrincipal == 's' || menuPrincipal == 'S') {
                // Operações
                Console.WriteLine("1 - Adição");

                Console.WriteLine("\n2 - Subtração");

                Console.WriteLine("\n3 - Multiplicação");

                Console.WriteLine("\n4 - Divisão");

                Console.Write("\nDigite o número da operação desejada: ");
                _ = int.TryParse(Console.ReadLine(), out int opcao);

                // Solicitando os valores para a operação
                Console.Write("\nDigite um número: ");
                _ = double.TryParse(Console.ReadLine(), out double num1);

                Console.Write("Digite outro número: ");
                _ = double.TryParse(Console.ReadLine(), out double num2);

                // Fazendo a operação que foi escolhida
                switch (opcao) {
                    case 1:
                        Console.WriteLine("O resultado é: {0}", num1 + num2);
                        break;

                    case 2:
                        Console.WriteLine("O resultado é: {0}", num1 - num2);
                        break;

                    case 3:
                        Console.WriteLine("O resultado é: {0}", num1 * num2);
                        break;

                    case 4:
                        Console.WriteLine("O resultado é: {0}", num1 / num2);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                // Pergunta se o usuário deseja voltar ao menu principal
                Console.Write("\nDeseja voltar ao menu principal?(S/N):");
                _ = char.TryParse(Console.ReadLine(), out menuPrincipal);
                Console.WriteLine("");
            }
        }
    }
}
