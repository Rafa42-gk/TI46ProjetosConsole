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
            string nome;
            int nota1, nota2, nota3, nota4, Resultado;
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
            Resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            //saída
            Console.WriteLine("O aluno " + nome + " teve média final: ", + Resultado);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
