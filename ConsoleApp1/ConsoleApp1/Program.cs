using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o nome do funcionário: ");
                string name = Console.ReadLine();
                Console.Write("Insira o ID do funcionário: ");
                string id = Console.ReadLine();

                // Crie e configure o objeto funcionário.
                Employee4 e = new Employee4(name, id);
                Console.Write("Insira o número atual de funcionários: ");
                string n = Console.ReadLine();
                Employee4.employeeCounter = Int32.Parse(n);
                Employee4.AddEmployee();

                // Exiba as novas informações.
                Console.WriteLine($"Nome: {e.name}");
                Console.WriteLine($"ID:   {e.id}");
                Console.WriteLine($"Novo numero de funcionarios: {Employee4.employeeCounter}");
                Console.ReadKey();
            } 
        }
        /*
        Input:
        Matthias Berndt
        AF643G
        15
         *
        Sample Output:
        Enter the employee's name: Matthias Berndt
        Enter the employee's ID: AF643G
        Enter the current number of employees: 15
        Name: Matthias Berndt
        ID:   AF643G
        New Number of Employees: 16
        */
    }

}
