// Faça um programa que exiba as opções:

// 1 – Conversão de Graus Celsius em Graus Fahrenheit
// 2 – Conversão de Graus Fahrenheit em Graus Celsius
// 3 – Peso ideal do homem
// 4 – Peso ideal da mulher

// O programa só deve encerrar quando o usuário digitar ´S´ para a pergunta “Deseja encerrar o programa?”
// Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio44 {

        private static void CelsiusFahrenheit() {
            // Solicitado a temperatura e salvo o valor na variável C
            Console.Write("\nFavor informe a temperatura em ºC: ");
            _ = uint.TryParse(Console.ReadLine(), out uint C);

            // coversão de ºC para ºF
            uint F = (9 * C + 160) / 5;
            Console.WriteLine("{0}ºC é equivalente a {1}ºF", C, F);
        }

        private static void FahrenheitCelsius() {
            // Solicitado a temperatura e salvo o valor na variável F
            Console.Write("\nFavor informe a temperatura em ºF: ");
            _ = uint.TryParse(Console.ReadLine(), out uint F);

            // Conversão de ºF para ºC
            uint C = (F - 32) * 5 / 9;
            Console.WriteLine($"{F}ºF é equivalente a {C}ºC");
        }

        private static void PesoIdealHomem() {
            // Solicitado altura ao usuário para que seja efetuado o calculo do peso ideal, salva na variável h
            Console.Write("\nFavor informe sua altura: ");
            _ = double.TryParse(Console.ReadLine(), out double altura);

            // Solicitado o peso atual ao usuário para que efetuado o status do peso atual, salva na variável p
            Console.Write("\nFavor informe o seu peso atual: ");
            _ = double.TryParse(Console.ReadLine(), out double peso);

            // Calculo do peso ideal
            double pesoIdeal = (72.7 * altura) - 58;

            // Imprime o peso ideal e o status do peso atual
            Console.WriteLine($"O seu peso ideal, para homem é: {pesoIdeal:F2}");
            Console.WriteLine("O status do seu peso atual é: {0}", StatusPeso(peso, pesoIdeal));
        }

        private static void PesoIdealMulher() {
            // Solicitado a altura ao usuário para que seja efetuado o calculo do peso ideal, salva na variável h
            Console.Write("\nFavor informe sua altura: ");
            _ = double.TryParse(Console.ReadLine(), out double altura);

            // Solicitado o peso atual ao usuário para que efetuado o status do peso atual, salva na variável p
            Console.Write("\nFavor informe o seu peso atual: ");
            _ = double.TryParse(Console.ReadLine(), out double peso);

            // Calculo do peso ideal
            double pesoIdeal = (62.1 * altura) - 44.7;

            // Imprime o peso ideal e o status do peso atual
            Console.WriteLine($"O peso ideal para mulher é: {pesoIdeal:F2}");
            Console.WriteLine("O status do seu peso atual é: {0}", StatusPeso(peso, pesoIdeal));
        }

        private static string StatusPeso(double peso, double pesoIdeal) {
            string statusPeso = "";
            if (peso < pesoIdeal) {
                statusPeso = "Abaixo do peso ideal!";
            } else if (peso > pesoIdeal) {
                statusPeso = "Acima do peso ideal!";
            }
            return statusPeso;
        }

        public static void Executar() {
            char parar;

            do {
                // Imprime as opções para usuário
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit.");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius.");
                Console.WriteLine("3 - Peso ideal do homem.");
                Console.WriteLine("4 - Peso ideal da mulher.");

                // Guardando a opção desejada
                Console.Write("\nDigite o número da operação desejada: ");
                _ = int.TryParse(Console.ReadLine(), out int opcao);

                switch (opcao) {
                    case 1:
                        CelsiusFahrenheit();
                        break;

                    case 2:
                        FahrenheitCelsius();
                        break;

                    case 3:
                        PesoIdealHomem();
                        break;

                    case 4:
                        PesoIdealMulher();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                // Pergunta se o usuário deseja encerrar o programa
                Console.Write("\nDeseja encerrar o programa?(S/N): ");
                _ = char.TryParse(Console.ReadLine(), out parar);
                Console.WriteLine("");

                // Condicional onde verifica se o laço será repetido
            } while (parar == 'n' || parar == 'N');

            // informa o fim do programa.
            Console.WriteLine("Fim!");
        }
    }
}
