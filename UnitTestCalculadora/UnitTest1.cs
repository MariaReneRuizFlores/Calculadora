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
        [Test]
        public void TestResta()
        {
            //Arrange=Preparación
            int num1 = 13;
            int num2 = 4;
            int esperado = 9;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.resta(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestRestar()
        {
            //Arrange=Preparación
            int num1 = 22;
            int num2 = 5;
            int esperado = 17;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.restar(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestMultiplicación()
        {
            //Arrange=Preparación
            int num1 = 2;
            int num2 = 5;
            int esperado = 10;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.multiplicación(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestMultiplicar()
        {
            //Arrange=Preparación
            int num1 = 15;
            int num2 = 3;
            int esperado = 45;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.multiplicar(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
    }
}