using System;

namespace Aula1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite seu nome, por favor:");
            string name = Console.ReadLine();

            string response;

            string calculator;
            do
            {
                Console.WriteLine($"{name}, digite o primeiro número:");
                int num1;
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine($"Você digitou o primeiro número: {num1}");

                    Console.WriteLine($"{name}, digite o segundo número:");
                    int num2;
                    if (int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine($"Você digitou o segundo número: {num2}. Gostaria de fazer qual operação aritmética (+,-,*,/)");
                        calculator = Console.ReadLine();
                        if (calculator == "+")
                        {
                            int sum = num1 + num2;
                            Console.WriteLine($"O resultado da soma do número {num1} com o número {num2} é: {sum}");
                        }
                        else if (calculator == "-")
                        {
                            int subtraction = num1 - num2;
                            Console.WriteLine($"O resultado da subtração do número{num1} pelo {num2} é: {subtraction}");
                        }
                        else if (calculator == "/")
                        {
                            int division = num1 / num2;
                            Console.WriteLine($"O resultado da divisão do número {num1} pelo {num2} é de: {division}");
                        }
                        else if (calculator == "*")
                        {
                            int multiplication = num1 * num2;
                            Console.WriteLine($"O resultado da multiplicação do número {num1} pelo {num2} é de: {multiplication}");
                        }
                        else
                        {
                            Console.WriteLine($"{name}, essa não é uma operação aritmética possível.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível converter o segundo número. Certifique-se de que é um número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Não foi possível converter o primeiro número. Certifique-se de que é um número válido.");
                }

                Console.WriteLine("Deseja continuar? (s/n)");
                response = Console.ReadLine();
            } while (response != "n");

            Console.ReadLine();
        }
    }
}