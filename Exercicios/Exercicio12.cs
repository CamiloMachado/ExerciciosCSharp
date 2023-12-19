namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia um número inteiro e exiba o seu módulo.
    // O módulo de um número x é:
    // x se x é maior ou igual a zero
    // x* (-1) se x é menor que zero

    internal class Exercicio12 {

        public void Executar() {
            // Variável
            int x;
            int modulo;

            // Solicitado o número ao usuário e converte para inteiro
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out x);

            // Decisão
            if (x >= 0) {
                modulo = x;
            } else {
                modulo = x * (-1);
            }
            Console.WriteLine("O modulo de {0} é {1}", x, modulo);
        }
    }
}
