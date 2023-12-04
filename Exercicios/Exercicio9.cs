namespace ExerciciosCSharp.Exercicios {
    // Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
    // Considerar ano com 365 dias e mês com 30 dias.

    internal class Exercicio9 {

        public static void Executar() {
            // Criação das variáveis
            uint anos = 38;
            uint meses = 3;
            uint dias = 4;

            // Converter anos em dias
            uint conversaoAnosEmDias = anos * 365;

            // Converter meses em dias
            uint conversaoMesesEmDias = meses * 30;

            // Calculo total da idade em dias
            uint diasDeVida = conversaoAnosEmDias + conversaoMesesEmDias + dias;
            Console.WriteLine($"Foram vividos {diasDeVida} dias de vida.");
        }
    }
}
