namespace ExerciciosCSharp.Exercicios {
    // Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, utilizando
    // as seguintes fórmulas: (h = altura)
    // - Para homens: (72.7* h) - 58
    // - Para mulheres: (62.1 * h) - 44.7

    internal class Exercicio25 {

        private static void Feminino(double h) {
            double pesoIdeal = (62.1 * h) - 44.7;
            Console.WriteLine($"\nO seu peso ideal é: {pesoIdeal:F2}");
            return;
        }

        private static void Masculino(double h) {
            double pesoIdeal = (72.7 * h) - 58;
            Console.WriteLine($"\nO seu peso ideal é: {pesoIdeal:F2}");
            return;
        }

        public static void Executar() {
            // Solicitando os dados ao usuário
            Console.Write("Favor informe sua altura: ");
            _ = double.TryParse(Console.ReadLine(), out double h);

            Console.WriteLine("\n1 - Feminino");
            Console.WriteLine("2 - Masculino");
            Console.Write("informe o seu sexo: ");
            _ = int.TryParse(Console.ReadLine(), out int sexo);

            switch (sexo) {
                case 1:
                    Feminino(h);
                    break;

                case 2:
                    Masculino(h);
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\nFim!");
        }
    }
}
