using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;
            Console.WriteLine("Determina qual é a pessoa mais velha");
           //leitura de dados pessoa 1
            Console.Write("Nome da pessoa 1: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade sa Pessoa 1: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());
            //leitura dados 2
            Console.Write("Nome da pessoa 2: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade sa Pessoa 2: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());
            //leitura idade 3
            Console.Write("Nome da pessoa 3: ");
            p3 = new Pessoa();
            p3.Nome = Console.ReadLine();
            Console.WriteLine("Idade sa Pessoa 3: ");
            p3.Idade = Convert.ToInt32(Console.ReadLine());
             
            //logica
            if((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade ))
            {
                Console.WriteLine("A pessoa mais velha é: " );
                p1.ExibirDados();   
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    p2.ExibirDados();


                }
                else
                {
                    if ((p3.Idade > p2.Idade) && (p3.Idade > p1.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        p3.ExibirDados();

                    }

                    else
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade!");
                    }
                } 

                Console.ReadKey();
            }
        }
    }
}
