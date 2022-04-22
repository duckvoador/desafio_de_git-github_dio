using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntasResposta
{
    internal class PerguntaPlus:Pergunta
    {
        public PerguntaPlus():base()
        {
           
            this.Dica = "";
        }
        public string Dica { get; set; }    

    }
}
