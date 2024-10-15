using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista03
    {
        public static void menu3()
        {
            Console.WriteLine(" Escolha uma operação:");
            Console.WriteLine(" 1 - Exercicio1 - ");
            Console.WriteLine(" 2 - Exercicio2 - ");
            Console.WriteLine(" 3 - Exercicio3 - ");
            Console.WriteLine(" 4 - Exercicio4 - ");
            Console.WriteLine(" 5 - Exercicio5 - ");
            Console.WriteLine(" 6 - Exercicio6 - ");

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

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.ReadKey();
        }

        private static void Exercicio1()
        {
            int n1;
            int n2;
            int n3;
            int soma;

            Console.WriteLine("Digite 3 numeros para a soma: ");
            Console.WriteLine("Primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terceiro numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2 + n3;

            Console.WriteLine($"A soma resultou em {soma}");
            Console.ReadKey();
        }

        private static void Exercicio2()
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

        private static void Exercicio3()
        {
            string nome;

            do
            {
                Console.WriteLine("Digite um nome: ", "Ou rafael para encerrar o programa \n");
                nome = Console.ReadLine();
            } while (nome != "Rafael");

            Console.WriteLine("Você digito Rafael! o programa será encerrado");
            Console.ReadKey();
        }

        private static void Exercicio4()
        {
            int inicio = 35;
            int fim = 98111;
            int n = 0;

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 2 == 0)
                {
                    n++;
                }
            }

            Console.WriteLine($"A quantidade de números pares entre {inicio} e {fim} é: {n}");
            Console.ReadKey();
        }

        private static void Exercicio5()
        {
            int soma = 0;

            for (int i = 1; i <= 5000; i += 2)
            {
                soma += i;
            }

            Console.WriteLine("A soma de todos os números ímpares de 1 até 5000 é: " + soma);
            Console.ReadKey();
        }

        private static void Exercicio6()
        {
            {
                int nm;

                Console.WriteLine("Digite um número para a tabuada: ");
                nm = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{nm} x {i} = {nm * i}");
                }

                Console.ReadKey();
            }
        }
    }
}
