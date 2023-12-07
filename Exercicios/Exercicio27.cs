namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia:
    // - a quantidade de números que deverá processar;
    // - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
    // Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N

    internal class Exercicio27 {

        private static int[] EscolhaNumeros(int numDeProcessamentos) {
            // Declarando o array que vai guardar os números que serão processados
            int[] processamentos = new int[numDeProcessamentos];

            // Laço para solicitar e guardar os números
            for (var i = 0; i < numDeProcessamentos; i++) {
                //Solicitando os valores ao usuário e guardando
                Console.Write($"\nDigite o número: ");
                _ = int.TryParse(Console.ReadLine(), out processamentos[i]);
            }

            // retorna o array
            return processamentos;
        }

        private static void Fatorial(int[] processamentos) {
            // Laco para receber os valores no array
            foreach (var num in processamentos) {
                // Variável para guardar o valor atua do array
                int valor = num;

                //Mostra o valor atual
                Console.Write($"\n{valor}");

                // Faz o calulo do Fatorial e mostra como é feito o calculo
                for (var i = valor; i > 1; i--) {
                    valor *= (i - 1);

                    Console.Write($" * {i - 1}");
                }

                // Mostra o valor final do fatorial
                Console.WriteLine($": {valor}");
            }
        }

        public static void Executar() {
            // Solicitando o valor de N!
            Console.Write("Digite quantos números deseja fazer a operação: ");
            _ = int.TryParse(Console.ReadLine(), out int numDeProcessamentos);

            // Chama o método que irá solicitar que o usuário indique os números que serão processados
            int[] processamentos = EscolhaNumeros(numDeProcessamentos);

            // Chama o método que irá fazer o processamento dos números dentro do array
            Fatorial(processamentos);
        }
    }
}
