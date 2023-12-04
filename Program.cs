using System;
using System.Collections.Generic;
using ExerciciosCSharp;
using ExerciciosCSharp.Exercicios;

namespace ExerciciosCSharp {

    internal class Program {

        private static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Exercícios
                {"Exercicio #01", Exercicio1.Executar},
                {"Exercicio #02", Exercicio2.Executar},
                {"Exercicio #03", Exercicio3.Executar},
                {"Exercicio #04", Exercicio4.Executar},
                {"Exercicio #05", Exercicio5.Executar},
                {"Exercicio #06", Exercicio6.Executar},
                {"Exercicio #07", Exercicio7.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
