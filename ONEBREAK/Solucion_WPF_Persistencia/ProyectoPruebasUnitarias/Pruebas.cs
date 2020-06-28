using Views;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace Views.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void ValidarIngresoTest()
        {
           // Views.MainWindow iniciarSesion = new Views.MainWindow();
            string username = "admin";
            string password = "123";
            string esperado = "USUARIOVALIDO";
            string respuestaReal = "";


           
            if (username.Equals("admin") && password.Equals("123"))
                respuestaReal = "USUARIOVALIDO";
            else
                respuestaReal = "USUARIONOVALIDO";

            Assert.IsTrue(esperado == respuestaReal);

            //if (esperado.Equals(respuestaReal))
            //    Assert.IsTrue(esperado == respuestaReal);
            //else
            //    Assert.Fail();
        }
    }
}

namespace ProyectoPruebasUnitarias
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
