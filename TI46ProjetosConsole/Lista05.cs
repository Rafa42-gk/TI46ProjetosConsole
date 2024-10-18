using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista05
    {
        public static void menu5() 
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
                    Exercicio6();
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
            double[] numeros = new double[10];
            double soma = 0;
            double media;
            int i;

            Console.WriteLine("Digite 10 números reais:");
            for ( i = 0; i < 10; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine());
                soma += numeros[i];
            }

            media = soma / 10;
            Console.WriteLine($"A média aritmética é: {media}");
            Console.ReadKey();
        }

        private static void Exercicio2()
        {
            string[] nomes = new string[5];

            Console.WriteLine("Digite 5 nomes:");
            for (int i = 0; i < 5; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);

            Console.WriteLine("Nomes em ordem alfabética:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }

        private static void Exercicio3()
        {
            int[] num = new int[10];
            int i;

            Console.WriteLine("Digite 10 numeros inteiros:");
            for ( i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            var repetidos = num.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);

            if (repetidos.Any())
            {
                Console.WriteLine("Números repetidos:");
                foreach (int numero in repetidos)
                {
                    Console.WriteLine(numero);
                }
            }
            else
            {
                Console.WriteLine("Não há números repetidos.");
            }
            Console.ReadKey();
        }

        private static void Exercicio4()
        {
            char[] palavra1 = new char[5];
            char[] palavra2 = new char[5];

            Console.WriteLine("Digite a primeira palavra de 5 caracteres:");
            for (int i = 0; i < 5; i++)
            {
                palavra1[i] = Console.ReadLine()[0];
            }

            Console.WriteLine("Digite a segunda palavra de 5 caracteres:");
            for (int i = 0; i < 5; i++)
            {
                palavra2[i] = Console.ReadLine()[0];
            }

            Array.Sort(palavra1);
            Array.Sort(palavra2);

            bool saoAnagramas = new string(palavra1) == new string(palavra2);

            if (saoAnagramas)
            {
                Console.WriteLine("As palavras são anagramas.");
            }
            else
            {
                Console.WriteLine("As palavras não são anagramas.");
            }
            Console.ReadKey();
        }

        private static void Exercicio5()
        {
            int[] num = new int[10];
            int i;
            Console.WriteLine("Digite 10 numeros inteiros:");

            for (i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(num);

            Console.WriteLine("Números na ordem inversa:");
            foreach (int numero in num)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }

        private static void Exercicio6()
        {
            int[] numeros = new int[5];
            int i;
            List<int> pares = new List<int>();

            Console.WriteLine("Digite 5 números inteiros:");
            for (i = 0; i < 5; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    pares.Add(numeros[i]);
                }
            }

            Console.WriteLine("Números pares:");
            foreach (int num in pares)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }

        private static void Exercicio7()
        {
            int[] numeros = new int[10];
            int negativo = 0;
            int positivo = 0;
            int zero = 0;
            int i;

            Console.WriteLine("Digite 10 números inteiros:");
            for (i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] < 0)
                {
                    negativo++;
                }
                else if (numeros[i] > 0)
                {
                    positivo++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine($"Numeros Positivos: {positivo}, Numeros Negativos: {negativo} e Zeros: {zero}.");
            Console.ReadKey();
        }

        private static void Exercicio8()
        {
            int[] num = new int[10];

            Console.WriteLine("Digite 10 números inteiros:");
            for (int i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int maior = num[0];
            int menor = num[0];

            foreach (int numero in num)
            {
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine($"Maior valor: {maior}, Menor valor: {menor}");
        }

        private static void Exercicio9()
        {
            char[] palavra = new char[5];

            Console.WriteLine("Digite uma palavra de 5 caracteres:");
            for (int i = 0; i < 5; i++)
            {
                palavra[i] = Console.ReadLine()[0];
            }

            bool ehPalindromo = true;
            for (int i = 0; i < 5 / 2; i++)
            {
                if (palavra[i] != palavra[5 - 1 - i])
                {
                    ehPalindromo = false;
                    break;
                }
            }

            if (ehPalindromo)
            {
                Console.WriteLine("A palavra é um palíndromo.");
            }
            else
            {
                Console.WriteLine("A palavra não é um palíndromo.");
            }
        }

        private static void Exercicio10()
        {
            int[] numeros = new int[10];
            int[] pares = new int[5];
            int[] impares = new int[5];
            int indicePar = 0;
            int indiceImpar = 0;
            int i;

            Console.WriteLine("Digite 10 números inteiros:");
            for (i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    pares[indicePar++] = numeros[i];
                }
                else
                {
                    impares[indiceImpar++] = numeros[i];
                }
            }

            Console.WriteLine("Números pares:");
            foreach (int numero in pares)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Números ímpares:");
            foreach (int numero in impares)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }

    }
}
