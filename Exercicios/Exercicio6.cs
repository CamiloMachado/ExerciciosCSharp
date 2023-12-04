namespace ExerciciosCSharp.Exercicios {
    // Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
    // A fórmula de conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
    // Fahrenheit e a variável C representa é a temperatura em graus Celsius.

    internal class Exercicio6 {

        public static void Executar() {
            // Criação da variável
            uint C = 32;

            // coversão de ºC para ºF
            uint F = (9 * C + 160) / 5;
            Console.WriteLine("{0}ºC é equivalente a {1}ºF", C, F);
        }
    }
}
