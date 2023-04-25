using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_c_.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobreNome)
        {
            this.Nome = nome;
            this.SobreNome = sobreNome;
        }
        private string _Nome;
        private int _Idade;
        public string Nome
        {
            //=> Boby Expresion para facilitar a leitura e a organização do codigo para comandos simples
            get => _Nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _Nome = value;
            }
        }
        public string SobreNome { get; set; }
        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
        public int Idade
        {
            get => _Idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O idade não pode ser menor que zero");
                }

                _Idade = value;
            }
        }
        public void apresentar()
        {
            Console.WriteLine($"NOME: {NomeCompleto} IDADE: {Idade}");
        }
    }
}