namespace ExerciciosCSharp.Exercicios {
    // Escrever um programa declarando três variáveis do tipo inteiro (a, b e c).
    // Ler um valor maior que zero para cada variável(se o valor digitado não é válido, mostrar mensagem e ler novamente).
    // Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor.

    internal class Exercicio20 {

        public static void Executar() {
            //Variáveis
            int menor;
            int maior;

            // Recebendo os valores
            Console.Write("Digite o primeiro valor: ");
            _ = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("\nDigite o segundo valor: ");
            _ = int.TryParse(Console.ReadLine(), out int b);
            Console.Write("\nDigite o terceiro valor: ");
            _ = int.TryParse(Console.ReadLine(), out int c);

            // Valindo se os valores recebidos são válido
            if (a < 0) {
                Console.WriteLine("\nValor inválido!");
                Console.Write("Digite o valor novamente: ");
                _ = int.TryParse(Console.ReadLine(), out a);
            } else if (b < 0) {
                Console.WriteLine("\nValor inválido!");
                Console.Write("Digite o valor novamente: ");
                _ = int.TryParse(Console.ReadLine(), out b);
            } else if (c < 0) {
                Console.WriteLine("\nValor inválido!");
                Console.Write("Digite o valor novamente: ");
                _ = int.TryParse(Console.ReadLine(), out c);
            }

            //  Valindo o maior valor recebido
            if (a > b && a > c) {
                maior = a;
            } else if (b > c) {
                maior = b;
            } else {
                maior = c;
            }

            //  Valindo o menor valor recebido
            if (a < b && a < c) {
                menor = a;
            } else if (b < c) {
                menor = b;
            } else {
                menor = c;
            }

            // Exibindo o reultado.
            Console.WriteLine("\nO resultado do menor valor multiplicado pelo maior valor é: {0}", (menor * maior));
            Console.WriteLine($"\nO resultado do maior valor dividido pelo menor valor é: {maior / menor}");
        }
    }
}
