using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class TestConta
    {
              
        public void SacarTest()
        {
            Pessoa pessoa = new Pessoa();
            var pessoaAtual = pessoa.BuscarPessoa(1235);
            //Conta conta = new Conta("0001", pessoaAtual, 300);
        }

        public void DepositarTest()
        {
            Pessoa pessoa = new Pessoa();
            var pessoaAtual = pessoa.BuscarPessoa(1235);
           // Conta conta = new Conta("0001", pessoaAtual, 300);
        }
    }
}
