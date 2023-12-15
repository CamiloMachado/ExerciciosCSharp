//Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um
//método chamado VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y.

//              Quadrantes
//                 x |
//                   |
//                2º | 1º
//                   |
// y --------------- 0 ---------------
//                   |
//                   |
//                3º | 4º
//                   |

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio60 {

        private static int Verifica_Quadrante(int x, int y) {
            if (x > 0 && y > 0) {
                return 1;
            } else if (x < 0 && y > 0) {
                return 2;
            } else if (x < 0 && y < 0) {
                return 3;
            } else if (x > 0 && y < 0) {
                return 4;
            } else {
                return 0;
            }
        }

        public static void Executar() {
            Console.WriteLine("O Quadrante é: {0}.", Verifica_Quadrante(1, 1));
            Console.WriteLine("O Quadrante é: {0}.", Verifica_Quadrante(-1, 1));
            Console.WriteLine("O Quadrante é: {0}.", Verifica_Quadrante(-1, -1));
            Console.WriteLine("O Quadrante é: {0}.", Verifica_Quadrante(1, -1));
            Console.WriteLine("O Quadrante é: {0}.", Verifica_Quadrante(0, 0));
        }
    }
}
