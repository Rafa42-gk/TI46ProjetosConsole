using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Criando um menu com switch case

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Exercício 1: Declaração de Variáveis");
            Console.WriteLine("2 - Exercício 2: Constantes e Operações");
            Console.WriteLine("3 - Exercício 3: Operações Aritméticas");
            Console.WriteLine("4 - Exercício 4: Prioridade dos Operadores");
            Console.WriteLine("5 - Exercício 5: Cálculo de Desconto");
            Console.WriteLine("6 - Exercício 6: Conversão de Temperaturas");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio1();
                    break;

                case 2:
                    Exercicio2();
                    break;

                case 3:
                    Exercicio3();
                    break;

                case 4:
                    Exercicio4();
                    break;

                case 5:
                    Exercicio5();
                    break;

                case 6:
                    Exercicio6();
                    break;

                case 7:
                    Lista01();
                    break;

                case 8:
                    Lista02();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para encerrar
        }

        // Exercício 1: Declaração de variáveis
        private static void Exercicio1()
        {
            // Declaração de variáveis
            int inteiro = 10;
            double real = 5.25;
            char caractere = 'A';

            // Saída
            Console.WriteLine("Valor inteiro: " + inteiro);
            Console.WriteLine("Valor real: " + real);
            Console.WriteLine("Valor caractere: " + caractere);
        }

        // Exercício 2: Constantes e Operações
        private static void Exercicio2()
        {
            const double Pi = 3.14159;
            double raio, area;

            Console.WriteLine("Digite o raio do círculo: ");
            raio = double.Parse(Console.ReadLine());

            area = Pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: " + area);
        }

        // Exercício 3: Operações Aritméticas
        private static void Exercicio3()
        {
            int num1, num2, num3;
            double media;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            media = (num1 + num2 + num3) / 3.0;

            Console.WriteLine("A média aritmética é: " + media);
        }

        // Exercício 4: Prioridade dos Operadores
        private static void Exercicio4()
        {
            double resultado = (2 + 3 * Math.Pow(4, 2)) / Math.Pow((1 - 5), 2);

            Console.WriteLine("O resultado da expressão é: " + resultado);
        }

        // Exercício 5: Cálculo de Desconto
        private static void Exercicio5()
        {
            double preco, precoFinal;
            const double desconto = 0.10;

            Console.WriteLine("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());

            precoFinal = preco - (preco * desconto);

            Console.WriteLine("O preço final com 10% de desconto é: " + precoFinal);
        }

        // Exercício 6: Conversão de Temperaturas
        private static void Exercicio6()
        {
            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9.0 / 5.0) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
        }
    }
}