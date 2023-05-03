using NUnit.Framework;
using TS2;

namespace TS2_Test
{
    public class PessoaDeMaiorTest
    {
        Pessoa pessoa;
        [SetUp]
        public void SteUp()
        {
            pessoa = new Pessoa();
        }
       

        [Test]
        public void PessoaDeMaior()
        {   bool resultadodoprograma = pessoa.eMaiorIdade(18);
            Assert.AreEqual(true, resultadodoprograma);

        }

        [Test]
        public void PessoaDeMenor()
        {
            bool resultadodoprograma = pessoa.eMaiorIdade(17);
            Assert.AreEqual(false, resultadodoprograma);

        }
        // => 18 ok <=17 false

        [Test]
        public void retornaTamanhoTexto()
        {
            // arrange
            Pessoa pessoa;
            string entrada = "casa";
            
            // act
            int resultadodoprograma = pessoa.retornaTamanhoTexto(entrada);
            int resultadoExperado = 4;

            // assert
            Assert.AreEqual(resultadoExperado, resultadodoprograma);

        }
    }
}