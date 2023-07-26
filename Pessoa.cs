using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13ClassesPOO
{
    internal class Pessoa
    {
        //listas

       

        //Variaveis (atributos)
        public string nome;
        public int idade;
        public string rua;
        public string cidade;

        //Método construtor
        public Pessoa(string nome , int idade , string rua , string cidade )
        {
            this.nome = nome;
            this.idade = idade;
            this.rua = rua;
            this.cidade = cidade;
            

        }

        //Funções (Métodos)

        public void mostra()
        {
           
            Console.WriteLine($"Olá, o seu nome é {nome} , você tem {idade} e mora na {rua} , cidade de {cidade}");
            Console.ReadKey();

        }



    }
}
