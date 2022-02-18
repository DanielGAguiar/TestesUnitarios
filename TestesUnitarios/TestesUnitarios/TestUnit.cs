using NUnit.Framework;

namespace TestesUnitarios
{
    [TestFixture]
    internal class TestUnit
    {
        Calc math;

        [SetUp]
        public void Setup()
        {
           math = new Calc();
        }
        [Test]  
        public void Somar()
        {             
               
            var resultado = math.Somar(10, 20);
            Assert.AreEqual(30, resultado);
            
        }

        [Test]
        public void Subtrair()
        {
            
            var resultado = math.Subtrair(50, 20);
            Assert.AreEqual(30, resultado);

        }

        [Test]
        public void Multiplicar()
        {
            
            var resultado = math.Multiplicar(5, 20);
            Assert.AreEqual(100, resultado);

        }

        [Test]
        public void Dividir()
        {
            
            var resultado = math.Dividir(100, 5);
            Assert.AreEqual(20, resultado);

        }
    }
}
