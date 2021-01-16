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
            //Arrange=Preparación
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.suma(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSumar()
        {
            //Arrange=Preparación
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.sumar(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
    }
}