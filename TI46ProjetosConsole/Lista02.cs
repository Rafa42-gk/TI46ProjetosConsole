using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista02
    {
        public static void menu2()
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
            Console.WriteLine(" 11 - Exercicio11 - ");

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

                case 11:
                    Exercicio11();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.ReadKey(); 
        }

        private static void Exercicio1()
        {
            int numero;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 20)
            {
                Console.WriteLine($"O número {numero} é maior que 20.");
            }
            else
            {
                Console.WriteLine($"O numero {numero} é menor que 20.");
            }

            Console.ReadKey();
        }

        private static void Exercicio2()
        {
            int n;

            Console.WriteLine("Digite um numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            {
                if (n > 10)
                {
                    Console.WriteLine("O numero é maior que 10"); ;

                }
                else
                {
                    Console.WriteLine("O numero não é maior que 10");
                }
                Console.ReadKey();
            }
        }

        private static void Exercicio3()
        {
            int A, B, C;
            
            Console.WriteLine("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());

            if (A + B >= C)
            {
                Console.WriteLine("A soma de A + B não é menor que C");
            }
            else
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }
            Console.ReadKey();
        }

        private static void Exercicio4()
        {
            int A, B;

            Console.WriteLine("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            if (A + B > 10)
            {
                Console.WriteLine("A soma de A + B é maior que 10");
            }
            else
            {
                Console.WriteLine("A soma de A + B é menor que 10");
            }
            Console.ReadKey();
        }

        private static void Exercicio5()
        {
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o sexo (M/F):");
            string sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o estado civil (solteiro(a), casado(a), divorciado(a), viuvo(a):");
            string estadocivil = Console.ReadLine().ToUpper(); 

            if (sexo == "F" && estadocivil == "casada")
            {
                Console.WriteLine("Digite o tempo de casada (em anos):");
                int tempo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadocivil}, Tempo de Casada: {tempo} anos.");
            }
            else
            {
                Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadocivil}.");
            }

            Console.ReadKey();
        }

        private static void Exrecicio6()
        {
            int n;

            Console.WriteLine("Digite um numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n%2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é ímpar");
            }
            Console.ReadKey();
        }

        private static void Exercicio7()
        {
            int A;
            int B;
            int C;

            Console.WriteLine("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());


            if (A == B)
            {
                C = A + B;
                Console.WriteLine($"Os valores são iguais. A soma de A + B é: {C}");
            }
            else
            {
                C = A * B;
                Console.WriteLine($"Os valores são diferentes. A multiplicação de A * B é: {C}");
            }

            Console.ReadKey();
        }

        private static void Exercicio8()
        {
            int n;
            int dobro;
            int triplo;

            Console.WriteLine("Digite um numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                dobro = n * 2;
                Console.WriteLine($"O numero é positivo, resultando em seu dobro: {dobro}");

            }
            else 
            {
                triplo = n * 3;
                Console.WriteLine($"O numero é negativo, resultando em seu triplo: {triplo}");

            }
            Console.ReadKey();
        }

        private static void Exercicio9()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            int[] valores = { valor1, valor2, valor3 };

            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine("Valores do maior para o menor: ");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();
        }

        private static void Exercicio10()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            int[] valores = { valor1, valor2, valor3 };

            Array.Sort(valores);

            Console.WriteLine("Valores do menor para o maior: ");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();
        }

        private static void Exercicio11()
        {
            int inicio;
            int fim;
            int duração;
            int tempoR;
            int tempoE;

            Console.WriteLine("Digite a hora de inico da partida: ");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a hora de fim da partida: ");
            fim = Convert.ToInt32(Console.ReadLine());

            if (inicio <= fim)
            {
                duração = fim - inicio;
            }
            else
            {
                duração = (24 - inicio) + fim;
            }

            Console.WriteLine($"A duração da partida foi de {duração} horas.");

            if (duração < 24)
            {
                tempoR = 24 - duração;
                Console.WriteLine($"Faltam {tempoR} horas até o fim do tempo limite.");
            }
            else if (duração == 24)
            {
                Console.WriteLine("A partida durou exatamente 24 horas.");
            }
            else
            {
                tempoE = duração - 24;
                Console.WriteLine($"A partida durou {tempoE} horas além do tempo limite permitido.");
            }

            Console.ReadKey();

        }
    }
}
