using System;
using System.Collections.Generic;
using System.Text;

namespace TS2
{
    public class Pessoa
    {

        public String nome;
        public int idade;
        public string endereco;

        public bool eMaiorIdade(int numero)
        {
            return numero >= 18 ? true : false;
        }
        int retornaTamanhoTexto(String texto)
        {
            return texto.Length;
        }

    }

    


}
