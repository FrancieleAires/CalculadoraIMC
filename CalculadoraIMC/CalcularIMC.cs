using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class CalcularIMC
    {

        public static double CalculandoIMC(double peso, double altura)
        {
            
            return peso / (altura * altura);
        }
        public void InterpretandoIMC(double imc)
        {
            if (imc < 18.4)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Normal!");
            }
            else if (imc >= 25 && imc <=29.9)
            {
                Console.WriteLine("Sobrepeso!");
            }
            else if (imc >= 30 &&  imc <= 34.9)
            {
                Console.WriteLine("Obesidade I!");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade II!");
            }
            else
            {
                Console.WriteLine("Obesidade III");
            }
        }
    }
}
