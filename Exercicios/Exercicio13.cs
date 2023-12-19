namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.

    internal class Exercicio13 {

        public static void Executar() {
            int primeiro;
            int segundo;
            int terceiro;

            // Solicitando os números.
            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("\nDigite o sgundo número: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.Write("\nDigite o terceiro número: ");
            int.TryParse(Console.ReadLine(), out int num3);

            // Ordenando os números

            // Validando quel é o maior número
            if (num1 > num2 && num1 > num3) {
                primeiro = num1;
            } else if (num2 > num3) {
                primeiro = num2;
            } else {
                primeiro = num3;
            }

            // Validando quel é o número intermediário
            if (num1 < num2 && num1 > num3 || num1 > num2 && num1 < num3) {
                segundo = num1;
            } else if (num2 < num1 && num2 > num3 || num2 > num1 && num2 < num3) {
                segundo = num2;
            } else {
                segundo = num3;
            }

            // Validando quel é o menor número
            if (num1 < num2 && num1 < num3) {
                terceiro = num1;
            } else if (num2 < num1 && num2 < num3) {
                terceiro = num2;
            } else {
                terceiro = num3;
            }

            Console.WriteLine($"\nOs números em ordem decrescente são: {primeiro} {segundo} {terceiro}");
        }
    }
}
