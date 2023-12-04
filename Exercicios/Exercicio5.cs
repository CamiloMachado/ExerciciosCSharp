using System;

namespace ExerciciosCSharp.Exercicios {
    //  Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12 Km por litro.
    //  Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
    //  Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
    //  Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12.
    //  O programa deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem.
    //  Dica: trabalhe com valores reais.

    internal class Exercicio5 {

        public static void Executar() {
            // Criação de variáveis
            double tempo = 0.75;             // horas
            double velocidadeMedia = 60;    // Km/h

            // Calculo de dsitancia
            double distancia = tempo * velocidadeMedia;
            Console.WriteLine($"A distência percorrida foi de {distancia} Km");

            // Calculo de combustível gasto
            double litrosUsados = distancia / 12;
            Console.WriteLine("Foram usados {0} litros nessa viagem.", litrosUsados);
        }
    }
}
