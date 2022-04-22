using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    class Mensagem
    {
        //private string TextoMensagem;

        //public void ExibirMensagem()
        // {
        //     Console.WriteLine(this.TextoMensagem);
        // }
        //public String getTextoMensagem()
        // {
        //      return this.TextoMensagem; 
        // }
        // public void setTextomensagem(String valor)
        //     { 
        //     this.TextoMensagem = valor.ToUpper(); 
        // }
        private String textoMensagem;
        public String TextoMensagem
        {
            get {
                return this.textoMensagem; 
            }   
            set {
                this.textoMensagem = value.ToUpper(); 
            }
        }
        public void ExibirMensagem()
        {
            Console.WriteLine(TextoMensagem);
        }
            

    }
}
