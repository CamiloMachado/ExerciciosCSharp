using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace ExerciciosCSharp.Exercicios {
    //  Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius.
    //  A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
    //  variável C é a temperatura em graus Celsius.

    internal class Exercicio7 {

        public static void Executar() {
            // Criação da variável
            uint F = 90;

            // Conversão de ºF para ºC
            uint C = (F - 32) * 5 / 9;
            Console.WriteLine($"{F}ºF é equivalente a {C}ºC");
        }
    }
}
