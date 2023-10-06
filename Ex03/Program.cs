using System;

namespace Ex3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Fala comigo. Como você se chama?");
            string name = Console.ReadLine();
            Console.WriteLine($"Beleza,{name}. Qual foi o valor total da conta aqui na Ada Lanches?");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Uhm, espero que tenha sido uma ótima refeição. E qual porcentagem de gorjeta desejada,{name}?");
            int percentage = int.Parse(Console.ReadLine());
            int tip = value * percentage / 100;
            int total = value + tip;
            Console.WriteLine($"{name}, o valor da gorjeta é de R${tip}. E o valor total a pagar é de: R${total}.");
            Console.ReadLine();
        }
    }
}
