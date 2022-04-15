using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaTeste
    {
        static void Main(string[] args)
        {
            testContaSacar();
            testContaSacarSemSaldo();
        }

        private static void testContaSacarSemSaldo()
        {
            Conta conta = new Conta("0001", 200);
            bool resultadoEsperado = false;

            bool resultado = conta.Sacar(250);

            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("Testar SacarSemSaldo: ok!"); 
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Testar SacarSemSaldo: falha!");
                Console.ReadLine();
            }
        }

        private static void testContaSacar()
        {
            Conta conta = new Conta("0001", 200);
            bool resultadoEsperado = true;

            bool resultado = conta.Sacar(50);

            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("Testar Sacar: ok!");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Testar Sacar: falha!");
                Console.ReadLine();
            }


        }
    }
}
