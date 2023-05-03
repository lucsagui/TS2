using System;
using System.Collections.Generic;
using System.Text;

namespace TS2
{
    public class validadorPessoa
    {
        public void validar(Pessoa pessoa)
        {
            if(pessoa == null)
            {
                throw new Exception("pessoa esta null");
            }

            if (pessoa.nome == null || pessoa.nome.Equals(""))
            {
                throw new Exception("Nome da pessoa esta invalida (null ou vazio)");
            }


        }
    }
}
    
    
    
           
                
          



   
