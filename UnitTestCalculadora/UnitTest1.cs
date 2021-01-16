using NUnit.Framework;
using ProyectoCalculadora.Properties.Controllers;

namespace UnitTestCalculadora
{
    public class TestsCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestSuma()
        {
            //Arrange=Preparaci�n
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.suma(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSumar()
        {
            //Arrange=Preparaci�n
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.sumar(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
    }
}