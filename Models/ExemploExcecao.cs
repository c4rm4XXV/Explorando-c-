using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_c_.Models
{
    public class ExemploExcecao
    {
        public void Metodo1 ()
        {
            try{
                Metodo2();
            } catch(Exception ex)
            {
                //StackTrace serve para expor o caminho percorrido por uma exceção até ela ser tratada 
                Console.WriteLine($"Exceção {ex.StackTrace} tratada");
            }
        }
        public void Metodo2 ()
        {
            Metodo3();
        }
        public void Metodo3 ()
        {
            Metodo4();
        }
        public void Metodo4 ()
        {
            //o termo throw ele joga o erro para cima até encontrar o bloco catch até a exceção ser tratada quaso não ache ele gera a excecion
            //tronando mais facio a localização 
            throw new Exception("Ocorreu um excecão");
        }
    }
}