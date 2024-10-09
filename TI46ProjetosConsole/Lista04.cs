using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista04
    {
        public static void menu4()
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Exercicio1 - ");
            Console.WriteLine("2 - Exercicio2 - ");
            Console.WriteLine("3 - Exercicio3 - ");
            Console.WriteLine("4 - Exercicio4 - ");
            Console.WriteLine("5 - Exercicio5 - ");
            Console.WriteLine("6 - Exercicio6 - ");
            Console.WriteLine("7 - Exercicio7 - ");
            Console.WriteLine("8 - Exercicio8 - ");
            Console.WriteLine("9 - Exercicio9 - ");
            Console.WriteLine("10 - Exercicio10 - ");

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
            throw new NotImplementedException();
        }

        private static void Exercicio2()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio3()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio4()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio5()
        {
            throw new NotImplementedException();
        }

        private static void Exrecicio6()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio7()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio8()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio9()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio10()
        {
            throw new NotImplementedException();
        }
    }
}
