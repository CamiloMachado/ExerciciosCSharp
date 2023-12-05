namespace ExerciciosCSharp.Exercicios {
    // Faça um programa que leia um número.
    // Se positivo armazene-o em A, se for negativo, em B.
    // No final mostrar o resultado.

    internal class Exercicio22 {

        public static void Executar() {
            // Variáveis
            double A = 0, B = 0;

            // Solicitando um valor ao usuário
            Console.WriteLine("Digite um número: ");
            _ = double.TryParse(Console.ReadLine(), out double num);

            // Validar onde o número escolhido será armazenado, armazenar e mostrar o resultado
            if (num > 0) {
                A = num;
                Console.WriteLine($"O valor {A} foi armazenado em A.");
            } else {
                B = num;
                Console.WriteLine($"O valor {B} foi armazenado em B.");
            }
        }
    }
}
