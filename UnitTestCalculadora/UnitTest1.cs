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
        public void TestSuma2()
        {
            //Arrange=Preparación
            int num1 = 8;
            int num2 = 9;
            int esperado = 17;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.suma(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSuma3()
        {
            //Arrange=Preparación
            int num1 = 3;
            int num2 = 2;
            int esperado = 5;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.suma(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSumar1()
        {
            //Arrange=Preparación
            int num1 = 3;
            int num2 = 7;
            int esperado = 10;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.sumar(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSumar2()
        {
            //Arrange=Preparación
            int num1 = 14;
            int num2 = 7;
            int esperado = 21;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.sumar(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSumar3()
        {
            //Arrange=Preparación
            int num1 = 5;
            int num2 = 2;
            int esperado = 7;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.sumar(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta1()
        {
            //Arrange=Preparación
            int num1 = 19;
            int num2 = 4;
            int esperado = 15;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.resta(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta2()
        {
            //Arrange=Preparación
            int num1 = 15;
            int num2 = 20;
            int esperado = -5;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.resta(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta3()
        {
            //Arrange=Preparación
            int num1 = 10;
            int num2 = 2;
            int esperado = 8;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.resta(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestRestar1()
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
        public void TestRestar2()
        {
            //Arrange=Preparación
            int num1 = 2;
            int num2 = 15;
            int esperado = -13;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.restar(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestRestar3()
        {
            //Arrange=Preparación
            int num1 = 8;
            int num2 = 4;
            int esperado = 4;
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
        [Test]
        public void TestDivisión()
        {
            //Arrange=Preparación
            int num1 = 75;
            int num2 = 25;
            int esperado = 3;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.división(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestDividir()
        {
            //Arrange=Preparación
            int num1 = 50;
            int num2 = 2;
            int esperado = 25;
            CalculadoraController calt = new CalculadoraController();
            //Act=ejecución
            int resultado = calt.dividir(num1, num2);

            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
    }
}