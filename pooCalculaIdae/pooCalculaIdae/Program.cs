using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdae
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que Calcula a Idade de uma Pessoa");
           
           
            Console.Write("Nome da Pessoa: ");
            String nome = Console.ReadLine();
            Console.Write("Ano de Nascimneto: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Pessoa p;
            p = new Pessoa(nome, ano);
           p.ExibirDados();
            Console.ReadKey();

        }
    }
}
