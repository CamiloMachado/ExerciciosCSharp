// Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA.
//
// O método recebe o valor da base e da altura de um triângulo.

// Fórmulas: hipotenusa² = base² + altura²
//            base x altura
// área = ----------------------
//                  2

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio62 {

        // Método onde é efetuado o calculo da hipotenusa
        private static double Hipotenusa(double baseTriangulo, double alturaTriangulo) {
            double valorHipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            return valorHipotenusa;
        }

        public static void Executar() {
            // Solicita o valor da base ao usuário
            Console.Write("Informe o valor da base: ");
            _ = double.TryParse(Console.ReadLine(), out double baseTriangulo);

            Console.WriteLine("");

            // Solicita o valor da altura ao usuário
            Console.Write("Informe o valor da altura: ");
            _ = double.TryParse(Console.ReadLine(), out double alturaTriangulo);

            Console.WriteLine("");

            double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);

            // Imprime o valor da Hipotenusa
            Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");
        }
    }
}
