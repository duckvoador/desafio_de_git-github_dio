using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonsapp
{
  public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";   
        }
        private String nome;

        public String Nome
        {
            get {
                return nome;
            }
            set {
                String texto = value.ToUpper(); 
                nome = texto; 
            }
        }
        private String descricao; //armazena o valor  da propriedade  DEscrição

        public String Descricao // representa  a Descrição do meu pokemon
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }



    }
}
