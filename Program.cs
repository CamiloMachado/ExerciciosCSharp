using System;
using System.Collections.Generic;
using ExerciciosCSharp;
using ExerciciosCSharp.Exercicios;

namespace ExerciciosCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Exercícios
                {"Exercicio #01", Exercicio1.Executar},
                {"Exercicio #02", Exercicio2.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}