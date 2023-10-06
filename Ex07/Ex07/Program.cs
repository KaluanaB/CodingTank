using System;

namespace Ex07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string responsibleName;
            string productName;
            string response;
            int totalSales;
            int productCode;
            float unitPrice;

            do
            {
                Console.WriteLine("Olá! Usuário, informe seu nome, por gentileza:");
                responsibleName = Console.ReadLine();
                Console.WriteLine($"Certo, {responsibleName}. Qual o produto?");
                productName = Console.ReadLine();
                Console.WriteLine($"Ok, e qual é o valor unitário do(a) {productName}");
                
                if (float.TryParse(Console.ReadLine(), out unitPrice))
                {
                    Console.WriteLine($"O valor informado de R${unitPrice} está correto? (s/n)");
                    response = Console.ReadLine();

                    if (response != "n")
                    {
                        Console.WriteLine($"Certo. E qual o código do produto {productName}");
                        
                        if (int.TryParse(Console.ReadLine(), out productCode))
                        {
                            Console.WriteLine($"Certo o código do(a) {productName} é {productCode}");
                            Console.WriteLine("Qual foi o total de vendas?");
                            
                            if (int.TryParse(Console.ReadLine(), out totalSales))
                            {
                                float result = unitPrice * totalSales;
                                Console.WriteLine($"Certo. O valor em R$ é de {result}");
                            }
                            else
                            {
                                Console.WriteLine("O número passado não é válido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não está correto. Vamos tentar novamente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parece que esse valor não é válido."); 
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
                
                Console.WriteLine("Deseja refazer o formulário? (s/n)");
                response = Console.ReadLine();
            } while (response == "s");
        }
    }
}
