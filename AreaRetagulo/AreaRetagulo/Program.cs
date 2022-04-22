using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetagulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Calcula a area de um retangulo");
            Console.Write("Informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a base: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibiDados();
            Console.ReadKey();
        }
    }
}
