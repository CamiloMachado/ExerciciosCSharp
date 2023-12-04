namespace ExerciciosCSharp.Exercicios {
    // Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes entre eles.
    // Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.

    internal class Exercicio10 {

        public static void Executar() {
            // Criação das variáveis
            uint num1 = 4;
            uint num2 = 7;

            //Comparar o relacionamento
            Console.WriteLine("O num1 é igual ao num2: {0}", num1 == num2);
            Console.WriteLine("O num1 é não igual ao num2: {0}", num1 != num2);
            Console.WriteLine("O num1 é maior ao num2: {0}", num1 > num2);
            Console.WriteLine("O num1 é menor ao num2: {0}", num1 < num2);
            Console.WriteLine("O num1 é maior igual ao num2: {0}", num1 >= num2);
            Console.WriteLine("O num1 é menor igual ao num2: {0}", num1 <= num2);
        }
    }
}
