using System;

namespace Ex09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name;
            int option;
            string cursoSelecionado;
            
            Console.WriteLine("Informe seu nome:");
            name = Console.ReadLine();
            Console.WriteLine("----****OPÇÕES DE CURSO****----");
            Console.WriteLine("Curso de Front-End");
            Console.WriteLine("Digite o número 1.");
            Console.WriteLine("Curso de Back-End");
            Console.WriteLine("Digite o número 2.");
            Console.WriteLine("Curso de lógica de programação");
            Console.WriteLine("Digite o número 3.");
            Console.WriteLine("Curso de C");
            Console.WriteLine("Digite o número 4.");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Digite o número 5.");
            
            Console.WriteLine($"{name}, informe o número do curso desejado:");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"{name} a opção escolhida foi {option}");
                    cursoSelecionado = "turma de Front-End";
                    break;
                case 2:
                    Console.WriteLine($"{name} a opção escolhida foi {option}");
                    cursoSelecionado = "turma de Back-End";
                    break;
                case 3:
                    Console.WriteLine($"{name} a opção escolhida foi {option}");
                    cursoSelecionado = "turma de Logica de programação";
                    break;
                case 4:
                    Console.WriteLine($"{name} a opção escolhida foi {option}");
                    cursoSelecionado = "turma de Linguagem C";
                    break;
                case 5:
                    Console.WriteLine($"{name} a opção escolhida foi {option}");
                    cursoSelecionado = "turma de Linguagem C#";
                    break;
                default:
                    cursoSelecionado = "Essa turma ainda não está disponível.";
                    break;
            }
            Console.WriteLine($"{name}, foi escolhida a {cursoSelecionado}");
        }
    }
}