// Faça um programa que leia 10 valores inteiros e positivos e:
// - Encontre o maior valor
// - Encontre o menor valor
// - Calcule a média dos números lidos

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio36 {

        public static void Executar() {
            // Criação do array conjunto e das variáveis para o menor valor, maior valor e a média.
            uint[] conjunto = new uint[10];
            uint menor, maior, total = 0, media;

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
                // Somar os valores para fazer a média
                total += num;

                // Teste para verificar se o número é negativo e saí do laco foreach
                if (num < 0) {
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

            media = total / 10;

            // Mostra o total dos pares e ímpares
            Console.WriteLine("\nO menor número é: {0}", menor);
            Console.WriteLine("O maior número é: {0}", maior);
            Console.WriteLine("O média é: {0}", media);
        }
    }
}
