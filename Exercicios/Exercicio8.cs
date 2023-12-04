namespace ExerciciosCSharp.Exercicios {
    // Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
    // V = 3.14159 * R * R * A
    // Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.

    internal class Exercicio8 {

        public static void Executar() {
            // Criação das variáveis
            double V = 0;
            double R = 4.5; // cm
            double A = 19;  // cm

            // Calculo do volume
            V = 3.14159 * R * R * A;
            Console.WriteLine("O valor do volme de uma lata de óleo é: {0}", V);
        }
    }
}
