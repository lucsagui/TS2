using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TS2;

namespace TS2_Test
{
    public class ValidadorPessoaTest
    {
        
        private validadorPessoa validadorPessoa;

        [SetUp]
        public void steup() 
        {
            validadorPessoa = new validadorPessoa();
        }

        [Test]
        public void validaPessoaComIdadeInvalida()
        {
            //arrenge
            Pessoa pessoa = criaPessoa();
            pessoa.idade = 151;

            //act,assert
            Assert.Throws<Exception> (() =>
              validadorPessoa.validar(pessoa));


        }

        [Test]
        public void validaPessoaValida()
        {
            //arrenge
            Pessoa pessoa = criaPessoa();
            
            //act,assert
            validadorPessoa.validar(pessoa);

        }

        private Pessoa criaPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.endereco = "cachoerinha";
            pessoa.idade = 100;
            pessoa.nome = "marcelo";
            return pessoa;
        }
        
    }
}
