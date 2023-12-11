// Faça um programa que determine o maior e o menor entre N números lidos.
// A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar executando
// até que a entrada seja igual a 0 (ZERO).

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio42 {

        public static void Executar() {
            // Criação do array conjunto e das variáveis para o menor valor, maior valor e a média.
            uint[] conjunto = new uint[10];
            uint menor, maior;

            conjunto[0] = 10;
            conjunto[1] = 5;
            conjunto[2] = 8;
            conjunto[3] = 9;
            conjunto[4] = 3;
            conjunto[5] = 12;
            conjunto[6] = 2;
            conjunto[7] = 4;
            conjunto[8] = 0;
            conjunto[9] = 11;

            menor = conjunto[0];
            maior = conjunto[0];

            // Aqui vai percorrer o conjunto
            foreach (var num in conjunto) {
                // Teste para verificar se o número é Zero e saí do laco foreach
                if (num == 0) {
                    break;
                } else {
                    // Se o número for positivo, fará o teste para ver se é maior ou menor
                    if (num > 0 && num > maior) {
                        maior = num;
                    } else if (num < menor) {
                        menor = num;
                    }
                }
            }

            // Mostra o menor e o maior
            Console.WriteLine("\nO menor número é: {0}", menor);
            Console.WriteLine("O maior número é: {0}", maior);
        }
    }
}
