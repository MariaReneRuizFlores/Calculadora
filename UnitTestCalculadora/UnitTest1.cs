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
        public void TestSuma1()
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
        public void TestSuma2()
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
        public void TestSuma3()
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
        public void TestSumar1()
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
        [Test]
        public void TestSumar2()
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
        [Test]
        public void TestSumar3()
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
        [Test]
        public void TestResta()
        {
            //Arrange=Preparaci�n
            int num1 = 13;
            int num2 = 4;
            int esperado = 9;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.resta(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestRestar()
        {
            //Arrange=Preparaci�n
            int num1 = 22;
            int num2 = 5;
            int esperado = 17;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.restar(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestMultiplicaci�n()
        {
            //Arrange=Preparaci�n
            int num1 = 2;
            int num2 = 5;
            int esperado = 10;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.multiplicaci�n(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestMultiplicar()
        {
            //Arrange=Preparaci�n
            int num1 = 15;
            int num2 = 3;
            int esperado = 45;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.multiplicar(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestDivisi�n()
        {
            //Arrange=Preparaci�n
            int num1 = 75;
            int num2 = 25;
            int esperado = 3;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.divisi�n(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestDividir()
        {
            //Arrange=Preparaci�n
            int num1 = 50;
            int num2 = 2;
            int esperado = 25;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecuci�n
            int resultado = calt.dividir(num1, num2);

            //Assert=verificaci�n
            Assert.AreEqual(esperado, resultado);
        }
    }
}