using System;
using System.Collections.Generic;
using ExerciciosCSharp;

namespace ExerciciosCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", Exercicio1.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}