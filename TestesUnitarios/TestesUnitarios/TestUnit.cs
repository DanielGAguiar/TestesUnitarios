using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios
{
    [TestFixture]
    internal class TestUnit
    {
        [Test]  
        public void Somar()
        {
            Calc math = new Calc();    
               
            var resultado = math.Somar(10, 20);
            Assert.AreEqual(30, resultado);
            
        }

        [Test]
        public void Subtrair()
        {
            Calc math = new Calc();

            var resultado = math.Subtrair(50, 20);
            Assert.AreEqual(30, resultado);

        }

        [Test]
        public void Multiplicar()
        {
            Calc math = new Calc();

            var resultado = math.Multiplicar(5, 20);
            Assert.AreEqual(100, resultado);

        }

        [Test]
        public void Dividir()
        {
            Calc math = new Calc();

            var resultado = math.Dividir(100, 5);
            Assert.AreEqual(20, resultado);

        }
    }
}
