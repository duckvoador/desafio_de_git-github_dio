using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
     public class Program
    {
        static void Main(string[] args)
        {
            Mensagem msgs1, msgs2;
            msgs1 = new Mensagem();
            msgs1.TextoMensagem = "Alô Mundo";
            msgs1.ExibirMensagem();   
            
           // msgs2 = new Mensagem();
           // msgs2.TextoMensagem = "Segundo Texto";
            //msgs2.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
