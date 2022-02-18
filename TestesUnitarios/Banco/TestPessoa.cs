using NUnit.Framework;

namespace Banco
{
    [TestFixture]
    internal class TestPessoa
    {
        [Test]
        public void BuscarPessoaTest()
        {
            Pessoa pessoa = new Pessoa();
            
            var resultado = pessoa.BuscarPessoa(1234);

            Assert.IsNotNull(resultado);    
        }

        [Test]
        public void BuscarPessoaNullTest()
        {
            Pessoa pessoa = new Pessoa();

            var resultado = pessoa.BuscarPessoa(1235);

            Assert.IsNull(resultado);
        }

        public void EditarPessoaTest() { }

        public void DeletarPessoaTest() { }
    }
}
