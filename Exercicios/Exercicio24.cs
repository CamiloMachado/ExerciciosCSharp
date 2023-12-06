namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja realizar:
    // 1 – Verificar se um dos números lidos é ou não múltiplo do outro
    // 2 – Verificar se os dois números lidos são pares
    // 3 – Verificar se a média dos dois números é maior ou igual a 7.
    // 4 – Sair

    internal class Exercicio24 {

        private static void Opcao1(int num1, int num2) {
            // Efetuando a operação
            if (num1 % num2 == 0) {
                Console.WriteLine($"\nO número {num1} é múltiplo de {num2}");
            }
            if (num2 % num1 == 0) {
                Console.WriteLine($"\nO número {num2} é múltiplo de {num1}");
            }
            if (num1 % num2 != 0 && num2 % num1 != 0) {
                Console.WriteLine($"\nOs números {num1} e {num2}, não são múltiplos um do outro!");
            }
            return;
        }

        private static void Opcao2(int num1, int num2) {
            // Efetuando a operação
            if (num1 % 2 == 0 && num2 % 2 == 0) {
                Console.WriteLine("\nOs dois números são pares!");
            } else if (num1 % 2 == 0) {
                Console.WriteLine($"\nApenas o número {num1} é par!");
            } else if (num2 % 2 == 0) {
                Console.WriteLine($"\nApenas o número {num2} é par!");
            } else {
                Console.WriteLine("\nNenhum dos números são pares!");
            }
            return;
        }

        private static void Opcao3(int num1, int num2) {
            // Efetuando a operação
            int media = (num1 + num2) / 2;
            if (media >= 7) {
                Console.WriteLine($"\nA média {media} dos dois números {num1} e {num2}, é maior ou igual a 7");
            } else {
                Console.WriteLine($"\nA média {media} dos dois números {num1} e {num2}, é menor do que 7");
            }
            return;
        }

        public static void Executar() {
            Console.WriteLine("----------------------------------------");

            // Solicitando os valores
            Console.Write("\nDigite um número: ");
            _ = int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("\nDigite outro número: ");
            _ = int.TryParse(Console.ReadLine(), out int num2);

            // Mostrando as opções para o usuário
            Console.WriteLine("\nEscolha uma das operações:");
            Console.WriteLine("\n1 - Verificar se um dos números é ou não múltiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números são pares");
            Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");

            // Guardando a opção desejada
            Console.Write("\nDigite o número da operação desejada: ");
            _ = int.TryParse(Console.ReadLine(), out int opcao);

            // Efetuando a opção desejada
            switch (opcao) {
                case 1:
                    Opcao1(num1, num2);
                    break;

                case 2:
                    Opcao2(num1, num2);
                    break;

                case 3:
                    Opcao3(num1, num2);
                    break;

                case 4:
                    Console.WriteLine("\nPrograma finalizado!");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    Console.WriteLine("Programa finalizado!");
                    break;
            }
            Console.WriteLine("\n----------------------------------------");
        }
    }
}
