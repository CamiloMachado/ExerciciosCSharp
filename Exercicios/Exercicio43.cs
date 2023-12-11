// Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço.

// O monge, necessitando de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito com
// grãos de trigo dispostos em um tabuleiro de xadrez, de tal forma que o primeiro quadro deveria
// conter apenas um grão e os quadros subseqüentes, o dobro do quadro anterior.

// A rainha achou o trabalho barato e pediu que o serviço fosse executado, sem se dar conta de que
// seria impossível efetuar o pagamento.

// Faça um programa para calcular o número de grãos que o monge esperava receber.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio43 {

        public static void Executar() {
            // variável
            double graos = 0;

            // laço para calcular o tanto de grãos
            for (int i = 1; i <= 64; i++) {
                graos += Math.Pow(2, i - 1);
                Console.WriteLine($"O valor de graos no quadrado {i:D2} é de: {graos}");
            }

            //Informando o tanto de grãos
            Console.WriteLine("O monge espera receber: {0} grãos", graos);
        }
    }
}
