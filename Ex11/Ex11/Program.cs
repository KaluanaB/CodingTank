using System;

namespace Ex11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name;
            string response;
            double salary;
            
            do
            {
                Console.WriteLine("Informe o nome do colaborador:");
                name = Console.ReadLine();
                Console.WriteLine($"Informe o salário do colaborador {name}:");
                if (!double.TryParse(Console.ReadLine(), out salary) || salary > 0)
                {
                    double increase;
                    double finalSalary;
                    double finalIncrease;
                    if (salary <= 280)
                    {
                        increase = 0.2;
                        finalIncrease = salary * increase;
                        finalSalary = finalIncrease + salary;
                        
                        Console.WriteLine($"O salário antes do reajuste é de: R${salary}");
                        Console.WriteLine($"O percentual de acrescimo é de: {increase}");
                        Console.WriteLine($"O valor do acréscimo é de: R${finalIncrease}");
                        Console.WriteLine($"O novo salário é de: R${finalSalary}");
                    }
                    else if (salary < 700)
                    {
                        increase = 0.15;
                        finalIncrease = salary * increase;
                        finalSalary = finalIncrease + salary;
                        
                        Console.WriteLine($"O salário antes do reajuste é de: R${salary}");
                        Console.WriteLine($"O percentual de acrescimo é de: {increase}");
                        Console.WriteLine($"O valor do acréscimo é de: R${finalIncrease}");
                        Console.WriteLine($"O novo salário é de: R${finalSalary}");
                    }
                    else if (salary < 1500)
                    {
                        increase = 0.1;
                        finalIncrease = salary * increase;
                        finalSalary = finalIncrease + salary;
                        
                        Console.WriteLine($"O salário antes do reajuste é de: R${salary}");
                        Console.WriteLine($"O percentual de acrescimo é de: {increase}");
                        Console.WriteLine($"O valor do acréscimo é de: R${finalIncrease}");
                        Console.WriteLine($"O novo salário é de: R${finalSalary}");
                    }
                    else
                    {
                        increase = 0.05;
                        finalIncrease = salary * increase;
                        finalSalary = finalIncrease + salary;
                        
                        Console.WriteLine($"O salário antes do reajuste é de: R${salary}");
                        Console.WriteLine($"O percentual de acrescimo é de: {increase}");
                        Console.WriteLine($"O valor do acréscimo é de: R${finalIncrease}");
                        Console.WriteLine($"O novo salário é de: R${finalSalary}");
                    }
                }
                else
                {
                    Console.WriteLine("O salário informado não é valido.");
                } 
                Console.WriteLine("Gostaria de informar um novo colaborador? (s/n)");
                response = Console.ReadLine();
            } while (response == "s");
        }
    }
}