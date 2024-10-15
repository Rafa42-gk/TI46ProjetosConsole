using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista04
    {
        public static void menu4()
        {
            Console.WriteLine(" Escolha uma operação:");
            Console.WriteLine(" 1 - Exercicio1 - ");
            Console.WriteLine(" 2 - Exercicio2 - ");
            Console.WriteLine(" 3 - Exercicio3 - ");
            Console.WriteLine(" 4 - Exercicio4 - ");
            Console.WriteLine(" 5 - Exercicio5 - ");
            Console.WriteLine(" 6 - Exercicio6 - ");
            Console.WriteLine(" 7 - Exercicio7 - ");
            Console.WriteLine(" 8 - Exercicio8 - ");
            Console.WriteLine(" 9 - Exercicio9 - ");
            Console.WriteLine(" 10 - Exercicio10 - ");

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
                    Exrecicio6();
                    break;

                case 7:
                    Exercicio7();
                    break;

                case 8:
                    Exercicio8();
                    break;
                case 9:
                    Exercicio9();
                    break;

                case 10:
                    Exercicio10();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.ReadKey(); 
        }

        private static void Exercicio1()
        {
            int n;

            Console.WriteLine("Digite um numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é ímpar");
            }
        }

        private static void Exercicio2()
        {
            Console.WriteLine("Por favor, insira a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Você é uma Criança.");
            }
            else if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine("Você é um Adolescente.");
            }
            else if (idade >= 18 && idade <= 64)
            {
                Console.WriteLine("Você é um Adulto.");
            }
            else if (idade >= 65)
            {
                Console.WriteLine("Você é um Idoso.");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }

            Console.ReadKey();
        }

        private static void Exercicio3()
        {
            double nota1;
            double nota2;
            double nota3;
            double media;

            Console.WriteLine("Digite suas notas");
            Console.WriteLine("Digite sua 1° nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 2° nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 3° nota: ");
            nota3 = double.Parse(Console.ReadLine());


            media = (nota1 + nota2 + nota3) / 3;
            if (media >= 6)
            {
                Console.WriteLine("Aluno Aprovado.");
            }
            else if (media >= 4 && media <= 5.9)
            {
                Console.WriteLine("Aluno em Recuperação.");
            }
            else if (media < 4)
            {
                Console.WriteLine("Aluno Reprovado");
            }
            else
            {
                Console.WriteLine("notas inválida.");
            }

            Console.ReadKey();
        }

        private static void Exercicio4()
        {
            Console.WriteLine("Informe seu peso em kg:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Categoria: Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Categoria: Peso normal.");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Categoria: Sobrepeso.");
            }
            else
            {
                Console.WriteLine("Categoria: Obesidade.");
            }

            Console.ReadKey();
        }

        private static void Exercicio5()
        {
            double n1;
            double n2;

            Console.WriteLine("Digite o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            if(n1 > n2)
            {
                Console.WriteLine("O primeiro valor é maior.");
             }
            else if(n1 < n2) 
            { 
                Console.WriteLine("O segundo valor é maior."); 
            }
            else
            {
                Console.WriteLine("Ambos valores são iguais.");
            }
            Console.ReadKey();
        }

        private static void Exrecicio6()
        {
            Console.WriteLine("Por favor, insira a sua idade:");
            double idade = double.Parse(Console.ReadLine());

            if (idade < 12)
            {
                Console.WriteLine("Você proibido de votar.");
            }
            else if (idade >= 18 && idade <= 70)
            {
                Console.WriteLine("Você é obrigado a votar.");
            }
            else if ((idade >= 16 && idade <= 17) || idade > 70)
            {
                Console.WriteLine("Você é voto facultativo.");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }

            Console.ReadKey();
        }

        private static void Exercicio7()
        {
            double resultado;
            double n;
            Console.WriteLine("Digite um valor em R$: ");
            n = Convert.ToDouble(Console.ReadLine());

            if (n > 100) 
            {
                resultado = n - (n / 10);
                Console.WriteLine($"O valor é maior que 100, portanto receberá um desconto de 10%: {resultado} ");

            }
            else 
            {
                Console.WriteLine($"O valor total ficou em : {n:F2}");
            }
            Console.ReadKey();

        }

        private static void Exercicio8()
        {
            int temperatura;

            Console.WriteLine("Informe a temperatura em C°: ");
            temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura < 15)
            {
                Console.WriteLine("A temperatura esta Fria");
            }
            else if(temperatura >15 && temperatura <25)
            {
                Console.WriteLine("A temperatura esta Agradavel");
            }
            else if(temperatura > 25)
            {
                Console.WriteLine("A temperatura esta Quente");
            }
            Console.ReadKey ();
        }

        private static void Exercicio9()
        {
            double n1;
            double n2;
            double n3;
            double media;

            Console.WriteLine("Digite sua notas trimestrais: ");
            Console.WriteLine("Primeira Nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segunda Nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Terceira Nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            if(media >= 7)
            {
                Console.WriteLine("Esta Aprovado");
            }
            else if (media < 7)
            {
                Console.WriteLine("Esta Reprovado");
            }
            Console.ReadKey ();
        }

        private static void Exercicio10()
        {
            int ano;

            Console.WriteLine("Digite um ano: ");
            ano = Convert.ToInt32(Console.ReadLine());

            // Verifica se o ano é bissexto
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine(ano + " é um ano bissexto.");
            }
            else
            {
                Console.WriteLine(ano + " não é um ano bissexto.");
            }

            Console.ReadKey();
        }
    }
}
