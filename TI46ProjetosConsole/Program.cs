using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        private static object exercicios1;

        static void Main(string[] args)
        {
            Exercicios0();
        }

        private static void Exercicios0()
        {
            string nome;
            int nota1, nota2, nota3, nota4; 
            double Resultado;
            Console.WriteLine("Digite seu nome: ");
            nome = (Console.ReadLine());
            Console.WriteLine("Seja Bem-vindo, ", nome);

            //Entre com as Notas
            Console.WriteLine("Digite a 1° nota do aluno: ", nome);
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2° nota do aluno: ", nome);
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3° nota do aluno: ", nome);
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 4° nota do aluno: ", nome);
            nota4 = int.Parse(Console.ReadLine());

            //processamento
            Resultado = (nota1 + nota2 + nota3 + nota4) / 4.0;

            //saída
            Console.WriteLine("O aluno " + nome + " teve média final: ", +Resultado);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

            Exercicios1();

        }

        private static void Exercicios1()
        {
            // Declaração de variáveis
            int inteiro = 10;
            double real = 5.25;
            char caractere = 'A';

            // Saída
            Console.WriteLine("Valor inteiro: " + inteiro);
            Console.WriteLine("Valor real: " + real);
            Console.WriteLine("Valor caractere: " + caractere);
            Console.ReadKey();


            exercicios2();
        }

        private static void exercicios2()
        {
            const double Pi = 3.14159;
            double raio, area;

            Console.WriteLine("Digite o raio do círculo: ");
            raio = double.Parse(Console.ReadLine());

            area = Pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: " + area);
            Console.ReadKey();


            exercicio3();
        }

        private static void exercicio3()
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
            Console.ReadKey();

            exercicio4();
        }

        private static void exercicio4()
        {
            double resultado = (2 + 3 * Math.Pow(4, 2)) / Math.Pow((1 - 5), 2);

            Console.WriteLine("O resultado da expressão é: " + resultado);
            Console.ReadKey();

            exercicio5();
        }

        private static void exercicio5()
        {
            double preco, precoFinal;
            const double desconto = 0.10;

            Console.WriteLine("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());

            precoFinal = preco - (preco * desconto);

            Console.WriteLine("O preço final com 10% de desconto é: " + precoFinal);
            Console.ReadKey();

            exercicio6();
        }

        private static void exercicio6()
        {
            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9.0 / 5.0) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
            Console.ReadKey();
        }
    }
}
