namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio1 {
        // Faça um programa para calcular o estoque médio de uma peça, sendo que:
        // ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

        public static void Executar() {
            // Criação das variáveis e iniciação.
            int quantidadeMinima = 10;
            int quantidadeMaxima = 100;

            // Calculo da média do estoque.
            int estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;

            // Mostrar no console o resultado do calculo.
            Console.WriteLine("O estoque médio da peça é: {0}", estoqueMedio);
        }
    }
}
