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

        //// / <summary>
        ///// Pruebas unitarias a metodo AddEntity Cliente
        ///// </summary>


        [TestMethod()]
        public void AgregarClienteExito()
        {

            //PRUEBA EXITOSA- registar un nuevo cliente, alcance el cliente 666 no debe existir en la bd.
            Cliente clientetest = new Cliente();

            clientetest.RutCliente = "4444";
            clientetest.RazonSocial = "Servicio";
            clientetest.NombreContacto = "Juanito";
            clientetest.MailContacto = "juan@hotmail.com";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;

            ServicioCliente sc = new ServicioCliente();

           //Assert.ThrowsException<ArgumentException>(() => sc.AddEntity(clientetest));


        }

        [TestMethod()]
        public void AgregarClienteSinExitoYaExiste()
        {

            //PRUEBA CON ERROR- NO SE GRABA PORQUE porque ya existe
            Cliente clientetest = new Cliente();

            clientetest.RutCliente = "201113334";
            clientetest.RazonSocial = "Servicio";
            clientetest.NombreContacto = "Juanito";
            clientetest.MailContacto = "juan@hot";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;

            ServicioCliente sc = new ServicioCliente();
            

            Assert.ThrowsException<ArgumentException>(() => sc.AddEntity(clientetest));


        }
        [TestMethod()]
        public void AgregarClienteSinExitoVacio()
        {

            //PRUEBA CON ERROR- NO SE GRABA PORQUE porque ya existe
            Cliente clientetest = new Cliente();
            clientetest.RutCliente = "";
            clientetest.RazonSocial = "Servicio";
            clientetest.NombreContacto = "Juanito";
            clientetest.MailContacto = "juan@hot";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;

            ServicioCliente sc = new ServicioCliente();
            Assert.ThrowsException<ArgumentException>(() => sc.AddEntity(clientetest));


        }












        ///// <summary>
        ///// //Pruebas Unitarias a Metodo DeleteEntity
        ///// 
        [TestMethod()]
        public void EliminarClienteconExito()
        {

            //PRUEBA EXITOSA- Eliminar el cliente 666  de la  bd.
            Cliente clientetest = new Cliente();

            clientetest.RutCliente = "555";
            clientetest.RazonSocial = "Servicio";
            clientetest.NombreContacto = "Juanito";
            clientetest.MailContacto = "juan@hotmail.com";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;

            ServicioCliente sc = new ServicioCliente();

            //Assert.ThrowsException<ArgumentException>(() => sc.DeleteEntity(clientetest.RutCliente));



        }

        [TestMethod()]
        public void EliminarClientesinExito_noExiste()
        {

            //PRUEBA sin exito - Eliminar cliente que no esta en base de datos
            Cliente clientetest = new Cliente();

            clientetest.RutCliente = "666";
            clientetest.RazonSocial = "Servicio";
            clientetest.NombreContacto = "Juanito";
            clientetest.MailContacto = "juan@hotmail.com";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;

            ServicioCliente sc = new ServicioCliente();
            //bool res = sc.DeleteEntity(clientetest.RutCliente);
            //Assert.AreEqual(true, res);
            Assert.ThrowsException<ArgumentException>(() => sc.DeleteEntity(clientetest.RutCliente));


        }

        [TestMethod()]
        public void EliminarClientesinExitoFaltaDato()
        {

            //PRUEBA sin exito - Eliminar cliente que no esta en base de datos
            Cliente clientetest = new Cliente();

            clientetest.RutCliente = "";
            clientetest.RazonSocial = "Servicio";
            clientetest.NombreContacto = "Juanito";
            clientetest.MailContacto = "juan@hotmail.com";
            clientetest.Telefono = "23243254";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;



            ServicioCliente sc = new ServicioCliente();
            Assert.ThrowsException<ArgumentException>(() => sc.DeleteEntity(clientetest.RutCliente));



        }


        /// <summary>
        // Creacion de pruebas Unitarias en metodo  Uppdate cliente
        // </summary>
        [TestMethod()]
        public void CambiarClienteconExito()
        {

            // PRUEBA EXITOSA-Actualizar cliente ya existente
            Cliente clientetest = new Cliente();


            clientetest.RutCliente = "4444";
            clientetest.RazonSocial = "Frutos del bosque";
            clientetest.NombreContacto = "Juanito perez";
            clientetest.MailContacto = "frutos@hotmail.com";
            clientetest.Telefono = "444444445";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;

            ServicioCliente sc = new ServicioCliente();

            //Assert.ThrowsException<ArgumentException>(() => sc.UpdateEntity(clientetest));
        }



        [TestMethod()]
        public void CambiarclienteSinExito()
        {

            // PRUEBA sin exito por que no existe el cliente
            Cliente clientetest = new Cliente();


            clientetest.RutCliente = "666";
            clientetest.RazonSocial = "Frutos del bosque";
            clientetest.NombreContacto = "Juanito perez";
            clientetest.MailContacto = "frutos@hotmail.com";
            clientetest.Telefono = "444444445";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;

            ServicioCliente sc = new ServicioCliente();

            Assert.ThrowsException<ArgumentException>(() => sc.UpdateEntity(clientetest));

        }


        [TestMethod()]
        public void CambiarclienteSinExitoDatoVacio()
        {

            // PRUEBA sin exito por que no hay un dato vacio 
            Cliente clientetest = new Cliente();


            clientetest.RutCliente = "";
            clientetest.RazonSocial = "Frutos del bosque";
            clientetest.NombreContacto = "Juanito perez";
            clientetest.MailContacto = "frutos@hotmail.com";
            clientetest.Telefono = "444444445";
            clientetest.Direccion = "calle mermelada 123";
            clientetest.IdTipoEmpresa = 10;
            clientetest.IdActividadEmpresa = 1;


            ServicioCliente sc = new ServicioCliente();

            Assert.ThrowsException<ArgumentException>(() => sc.UpdateEntity(clientetest));
        }

        
    }
}


