using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios
{
    internal class TestCalc
    {
        public void SomarTest()
        {
            //Arrange
            Calc math = new Calc();
            var resultadoEsperado = 30;

            //Act
            var resultado = math.Somar(10, 20);

            //Assert
            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("Teste Somar: Ok!");
            }
            else
            {
                Console.WriteLine("Teste Somar: Falhou!");
            }
            
        }

        public void SubtrairTest()
        {
            //Arrange
            Calc math = new Calc();
            var resultadoEsperado = 30;

            //Act
            var resultado = math.Subtrair(50, 20);

            //Assert
            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("Teste Subtrair: Ok!");
            }
            else
            {
                Console.WriteLine("Teste Subtrair: Falhou!");
            }

        }

        public void MultiplicarTest()
        {
            //Arrange
            Calc math = new Calc();
            var resultadoEsperado = 100;

            //Act
            var resultado = math.Multiplicar(5, 20);

            //Assert
            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("Teste Multiplicar: Ok!");
            }
            else
            {
                Console.WriteLine("Teste Multiplicar: Falhou!");
            }

        }

        public void DividirTest()
        {
            //Arrange
            Calc math = new Calc();
            var resultadoEsperado = 20;

            //Act
            var resultado = math.Dividir(100, 5);

            //Assert
            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("Teste Multiplicar: Ok!");
            }
            else
            {
                Console.WriteLine("Teste Multiplicar: Falhou!");
            }

        }
    }
}
