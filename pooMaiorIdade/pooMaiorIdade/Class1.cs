﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    public class Pessoa
    {
        //contrutores
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }

        public Pessoa(string nome,  int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            
        }


        //propriedades
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        private int idade;
        public int Idade
        {
            get { return idade; } 
            set {
                if (value>= 0)
                { idade = value; }
                else
                {
                    this.idade = 0;
                }
            } 
        }
        //Metodos
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: "+this.Idade);
        }


    }
}
