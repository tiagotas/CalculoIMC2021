using System;

namespace CalculoIMC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * imc = peso / (altura * altura)
             */
            double imc, peso, altura;
            string nome;

            Console.WriteLine("Cálculo do Índice de Massa Corporal - IMC");

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu peso, em kilos: ");
            peso = Convert.ToDouble(Console.ReadLine());

            // Realizando o cálculo do IMC
            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc);

            /**
             * Regras de Classificação do IMC
             * IMC abaixo de 18,5    = "Muito abaixo do peso".
             * IMC entre 18,5 e 24,9 = "Peso Normal"
             * IMC entre 25,0 e 29,9 = "Sobre peso"
             * IMC entre 30,0 e 34,9 = "Obesidade Grau I"
             * IMC entre 35,0 e 39,9 = "Obesidade Grau II"
             * IMC maior que 40 = "Obesidade Grau III ou Mórbida"
             */ 

            // SE = if
            // SENÃO = else

            if (imc < 18.5)
            {
                Console.WriteLine("Muito abaixo do peso.");
                                // E
            } else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal.");

            } else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Você está com sobrepeso.");

            } else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Você está com Obesidade Grau I");

            } else if(imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Você está com Obesidade Grau II");

            } else 
            {
                Console.WriteLine("Você está com Obesidade Grau III");
            }







            Console.ReadKey();
            
        }
    }
}
