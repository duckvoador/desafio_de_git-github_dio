using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdae
{
    
    public class Pessoa
    {   
        public Pessoa(String nomePessoa, int anoNascimnetoPessoa)
        {
            this.Nome = nomePessoa;
            this.AnoNascimento = anoNascimnetoPessoa;
            this.CalcularIdade();
        }
        private int anoNascinmento;

        public int AnoNascimento
        {
            get { return this.anoNascinmento; }
            set { this.anoNascinmento = value; }
        }

        private String nome;
        public String Nome 
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

      
        private int idade;

        public int Idade
        {
            get {
                this.CalcularIdade();
                return this.idade; }
        }
        





        public void ExibirDados()
        {
            Console.WriteLine("Nome:"+this.Nome);
            Console.WriteLine("Ano de Nascimento:"+ this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: "+this.Idade);
        }
        private void CalcularIdade() 
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;
           
            
        }


    }   
}
