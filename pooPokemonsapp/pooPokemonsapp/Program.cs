using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonsapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            p.Nome = "Bullbasauro";
            p.Descricao = "se trata de um especime tipo planta";
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
