namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia dois números e apresente a diferença do maior para o menor.

    internal class Exercicio14 {

        public void Executar() {
            // variáveis
            int maior;
            int menor;
            int diferenca;

            // Solicitado os números
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("\nDigite outro número: ");
            int.TryParse(Console.ReadLine(), out int num2);

            //Validando e ordenando os números e calculando a diferença
            if (num1 > num2) {
                maior = num1;
                menor = num2;
                diferenca = num1 - num2;
            } else {
                maior = num2;
                menor = num1;
                diferenca = num2 - num1;
            }
            Console.WriteLine("\nA diferença entre os números {0} e {1} é {2}", maior, menor, diferenca);
        }
    }
}
