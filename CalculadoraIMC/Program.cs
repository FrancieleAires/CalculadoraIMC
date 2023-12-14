using System;
using System.Globalization;


namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela valores do IMC - 20 a 60 anos.");
            Console.WriteLine("╔════════════════════════════╗");
            Console.WriteLine("║Abaixo do peso |  < 18.4    ║");
            Console.WriteLine("║Normal         | 18.5 - 24.9║");
            Console.WriteLine("║Sobrepeso      | 25 - 29.9  ║");
            Console.WriteLine("║Obesidade I    | 30 - 34.9  ║");
            Console.WriteLine("║Obesidade II   | 35 - 39.9  ║");
            Console.WriteLine("║Obesidade III  |  >  40     ║");
            Console.WriteLine("╚════════════════════════════╝");

            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CalcularIMC calcular = new CalcularIMC();
            Console.WriteLine();
            double imc = CalcularIMC.CalculandoIMC(peso, altura);
         

            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Seu IMC na tabela é: " );
            calcular.InterpretandoIMC(imc);
            
            
        }
    }
}