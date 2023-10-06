using System;

namespace Ex06
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Olá. Qual seu nome?");
            string name = Console.ReadLine();
            string response;
            
            do
            {
                Console.WriteLine($"Certo, {name}. E qual sua idade, por favor?");
                int age;
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine($"{name}, você digitou {age}.");
                    if (age > 4 && age < 8)
                    {
                        Console.WriteLine($"{name}, você está na categoria e Infantil A.");
                    }
                    else if (age > 7 && age < 12)
                    {
                        Console.WriteLine($"{name}, você está na categoria e Infantil B."); 
                    }
                    else if (age > 11 && age < 14) 
                    {
                        Console.WriteLine($"{name}, você está na categoria e Infantil C.");
                    }
                    else if (age > 13 && age < 18)
                    {
                        Console.WriteLine($"{name}, você está na categoria e Infantil D.");
                    }
                    else if (age >= 18 && age < 93)
                    {
                        Console.WriteLine($"{name}, você está na categoria de adulto.");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, parece que essa idade não é valida.");
                    }
                }
                else
                {
                    Console.WriteLine($"{name}, parece que o você não digitou um número válido.");
                }
                Console.WriteLine("Deseja continuar? (s/n)");
                response = Console.ReadLine();
            } while (response != "n");
            
            Console.ReadLine();
        }
    }
}