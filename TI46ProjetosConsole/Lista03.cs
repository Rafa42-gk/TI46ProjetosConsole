using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista03
    {
        public void escolherexercicio()
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Exercicio1 - ");
            Console.WriteLine("2 - Exercicio2 - ");
            Console.WriteLine("3 - Exercicio3 - ");
            Console.WriteLine("4 - Exercicio4 - ");
            Console.WriteLine("5 - Exercicio5 - ");
            Console.WriteLine("6 - Exercicio6 - ");

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
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para encerrar
        }

        private void Exercicio1()
        {
            throw new NotImplementedException();
        }

        private void Exercicio2()
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

        private void Exercicio3()
        {
            string nome;

            Console.WriteLine("Digite seu Nome: ");
            nome = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite um nome: ", "Ou rafael para encerrar o programa \n");
                nome = Console.ReadLine();
            } while (nome != "Rafael");

            Console.WriteLine("Você digito Rafael! o programa será encerrado" );
            Console.ReadKey();
        }

        private void Exercicio4()
        {
            throw new NotImplementedException();
        }

        private void Exercicio5()
        {
            throw new NotImplementedException();
        }

        private void Exercicio6()
        {
            throw new NotImplementedException();
        }
    }
}
