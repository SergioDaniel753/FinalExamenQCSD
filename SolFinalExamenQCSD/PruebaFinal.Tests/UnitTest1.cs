
using FinalExamenQCSD.Controllers;
using NUnit.Framework;

namespace NUnitTest1
{
    public class TestLetra
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Letra()
        {
            //Arrange=preparacion
            string num1 = "0";
            string esperado = "Cero";
            ConvertidorNumController lit = new ConvertidorNumController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void Letra2()
        {
            //Arrange=preparacion
            string num1 = "5";
            string esperado = "Cinco";
            ConvertidorNumController lit = new ConvertidorNumController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void Letra3()
        {
            //Arrange=preparacion
            string num1 = "10.2";
            string esperado = "Diez punto dos";
            ConvertidorNumController lit = new ConvertidorNumController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void Letra4()
        {
            //Arrange=preparacion
            string num1 = "-3";
            string esperado = "Menos tres";
            ConvertidorNumController lit = new ConvertidorNumController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }

        [Test]
        public void Letra5()
        {
            //Arrange=preparacion
            string num1 = "1234567.89";
            string esperado = "Un millon doscientos treinta y cuatro mil quinientos sesenta y siete punto ochenta y nueve";
            ConvertidorNumController lit = new ConvertidorNumController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }

    }
}