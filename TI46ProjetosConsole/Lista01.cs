using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TI46ProjetosConsole
{
    internal class Lista01
    {
        public static void menu1()
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
            Console.WriteLine("Hello World!!!");
            Console.ReadKey();
        }

        private static void Exercicio2()
        {
            string nome;

            Console.WriteLine("Qual é o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}, é um prazer te conhecer!");

            Console.ReadKey();
        }

        private static void Exercicio3()
        {
            string nome;
            double salario;

            Console.WriteLine("Nome do funcionário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O funcionario {nome} tem o salario de {salario:F2}R$");

            Console.ReadKey();
        }

        private static void Exercicio4()
        {
            int valor1;
            int valor2;
            int soma;


            Console.WriteLine("Digite um valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            soma = valor1 + valor2;

            Console.WriteLine($"A soma entre {valor1} e {valor2} é igual a {soma}.");

            Console.ReadKey();
        }

        private static void Exercicio5()
        {
            double nota1;
            double nota2;
            double media;


            Console.WriteLine("Digite um valor: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine($"A média de {nota1} mais {nota2} é igual a {media}.");

            Console.ReadKey();
        }

        private static void Exrecicio6()
        {
            double n;
            double antecessor;
            double sucessor;


            Console.WriteLine("Digite um valor: ");
            n = Convert.ToDouble(Console.ReadLine());

            antecessor = n - 1;
            sucessor = n + 1;

            Console.WriteLine($"o antecessor de {n} é {antecessor} e o sucessor é {sucessor}.");

            Console.ReadKey();
        }

        private static void Exercicio7()
        {
            double n;
            double dobro;
            double terço;

            Console.WriteLine("Digite um valor: ");
            n = Convert.ToDouble(Console.ReadLine());

            dobro = n * 2;
            terço = n / 3;

            Console.WriteLine($"o dobro de {n} é {dobro} e o terço é {terço}.");

            Console.ReadKey();
        }

        private static void Exercicio8()
        {
            Console.WriteLine("Digite uma distância em metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());

            double km = metros / 1000;   
            double hm = metros / 100;    
            double dam = metros / 10;    
            double dm = metros * 10;     
            double cm = metros * 100;    
            double mm = metros * 1000;   

            Console.WriteLine($"\nA distância de {metros}m corresponde a:");
            Console.WriteLine($"{km} Km");
            Console.WriteLine($"{hm} Hm");
            Console.WriteLine($"{dam} Dam");
            Console.WriteLine($"{dm} dm");
            Console.WriteLine($"{cm} cm");
            Console.WriteLine($"{mm} mm");

            Console.ReadKey();
        }

        private static void Exercicio9()
        {
            double reais;
            double dolar;
            double valor;

            Console.WriteLine("Digite um valor em R$: ");
            reais = Convert.ToDouble(Console.ReadLine());

            dolar = 3.45;

            valor = reais / dolar;

            Console.WriteLine($"O valor de R${reais} em Dolares é: {valor}");
            Console.ReadKey();
        }

        private static void Exercicio10()
        {
            double altura;
            double largura;
            double area;
            double tinta;

            Console.WriteLine("Digite o valor da altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de largura: ");
            largura = Convert.ToDouble(Console.ReadLine());

            area = altura * largura;

            tinta = area / 2;

            Console.WriteLine($"A área total a ser pintada é de {area} m², e o total de tinta necessária para pintá-la é de {tinta} L.");
            Console.ReadKey();
        }
    }
}
