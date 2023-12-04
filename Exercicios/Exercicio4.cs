using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Text;

namespace ExerciciosCSharp.Exercicios {
    //  Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
    //  valores lidos, baseando-se na utilização do conceito de propriedade distributiva.Dica: se forem lidas as variáveis
    //  A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
    //  com D e por último C com D.Note que para cada operação serão utilizadas seis combinações. Assim sendo,
    //  devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as multiplicações.

    internal class Exercicio4 {

        public static void Executar() {
            // Criação das váriaveis
            int A = 4;
            int B = 9;
            int C = 1;
            int D = 7;

            // Adição
            int adicao1 = A + B;
            int adicao2 = A + C;
            int adicao3 = A + D;
            int adicao4 = B + C;
            int adicao5 = B + D;
            int adicao6 = C + D;

            // Multiplicação
            int multiplicacao1 = A * B;
            int multiplicacao2 = A * C;
            int multiplicacao3 = A * D;
            int multiplicacao4 = B * C;
            int multiplicacao5 = B * D;
            int multiplicacao6 = C * D;

            //int distributiva = A * B + A * C + A * D + B * C + B * D + C * D;
        }
    }
}
