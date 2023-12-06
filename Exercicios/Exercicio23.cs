namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
    // 1 – Adição
    // 2 – Subtração
    // 3 – Multiplicação
    // 4 – Divisão

    internal class Exercicio23 {

        public static void Executar() {
            // Solicitando os valores para a operação
            Console.Write("Digite um número: ");
            _ = double.TryParse(Console.ReadLine(), out double num1);

            Console.Write("\nDigite outro número: ");
            _ = double.TryParse(Console.ReadLine(), out double num2);

            // Operações
            Console.WriteLine("1 - Adição");

            Console.WriteLine("\n2 - Subtração");

            Console.WriteLine("\n3 - Multiplicação");

            Console.WriteLine("\n4 - Divisão");

            Console.Write("\nDigite o número da operação desejada: ");
            _ = int.TryParse(Console.ReadLine(), out int opcao);

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
        }
    }
}
