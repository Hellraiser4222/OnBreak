using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersistenciaBD;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios.Tests
{
    [TestClass()]
    public class ServicioClienteTests
    {
        [TestMethod()]
        public void AgregarClienteSinNombreTest()
        {

            Cliente clientetest = new Cliente();
            

            clientetest.RutCliente = "12345678";
            clientetest.RazonSocial = "Servicio";
            clientetest.NombreContacto ="";
            clientetest.MailContacto = "juan@hot";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";

           // Exception ex;
            ServicioCliente sc = new ServicioCliente();
            int res = sc.AddEntity(clientetest);

            //Assert.ThrowsException<Exception>(sc.AddEntity(clientetest));



            Assert.Fail();
        }

        [TestMethod()]
        public void AgregarClienteCompletoTest()
        {
            Cliente clientetest = new Cliente();
            ServicioCliente sc = new ServicioCliente();
            int resEsperado = 1;

            clientetest.RutCliente = "12345678";
            clientetest.RazonSocial = "Servicio Perez";
            clientetest.NombreContacto = "Juan Perez";
            clientetest.MailContacto = "juan@hot";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";

            int res = 0;
            res = sc.DeleteEntity(clientetest);
            Assert.Equals(res, resEsperado);
        }

    }

}