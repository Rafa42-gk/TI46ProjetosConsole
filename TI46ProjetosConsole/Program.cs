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
            Console.WriteLine(" === Menu de Atividades ===");
            Console.WriteLine(" 1 - Lista01 - ");
            Console.WriteLine(" 2 - Lista02 - ");
            Console.WriteLine(" 3 - Lista03 - ");
            Console.WriteLine(" 4 - Lista04 - ");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Lista01.menu1();
                    break;

                case 2:
                    Lista02.menu2();
                    break;

                case 3:
                    Lista03.menu3();
                    break;

                case 4:
                    Lista04.menu4();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.ReadKey();




        }
    }
}