using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhoraDoPich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alarme alarme = new Alarme();
            Alarme alarme;
            String resposta = "S";
            while (resposta != "N")
            {
                Console.Clear();
                Console.WriteLine("A hora do Pitch");
                Console.WriteLine("Informe a Duração do Pinch");
                int tempo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o efeito sonoro(1 ate 500");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());
                //alarme.EfeitoSonoro = efeitoSonoro;
                alarme = new Alarme(tempo, efeitoSonoro);
                alarme.Iniciar();
                Console.WriteLine("Que pena!!! O seu tempo acabou!!!!");
                Console.WriteLine("Executar o progama novamente: S/N");
                resposta =  Console.ReadLine().ToUpper();
            }
        }
    }
}
