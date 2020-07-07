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
        // / <summary>
        /// Pruebas unitarias a metodo AddEntity Cliente
        /// </summary>
        [TestMethod()]
        public void AgregarClienteConExito()
        {
            try
            {
                //PRUEBA EXITOSA- registar un nuevo cliente, alcance el cliente 666 no debe existir en la bd.
                Cliente clientetest = new Cliente();
                clientetest.RutCliente = "636";
                clientetest.RazonSocial = "Servicio";
                clientetest.NombreContacto = "Juanito";
                clientetest.MailContacto = "juan@hotmail.com";
                clientetest.Telefono = "23243254";
                clientetest.Direccion = "calle mermelada 123";
                clientetest.IdTipoEmpresa = 10;
                clientetest.IdActividadEmpresa = 1;

                ServicioCliente sc = new ServicioCliente();
                int res = sc.AddEntity(clientetest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }

        [TestMethod()]
        public void AgregarClienteSinExitoFaltaDato()
        {
            try
            {
                //PRUEBA CON ERROR- NO SE GRABA PORQUE FALTA CAMPO OBLIGATORIO
                Cliente clientetest = new Cliente();
                clientetest.RutCliente = "";
                clientetest.RazonSocial = "Servicio";
                clientetest.NombreContacto = "Juanito";
                clientetest.MailContacto = "juan@hot";
                clientetest.Telefono = "23243254";
                clientetest.Direccion = "calle mermelada 123";
                clientetest.IdTipoEmpresa = 10;
                clientetest.IdActividadEmpresa = 1;

                if (string.IsNullOrEmpty(clientetest.RutCliente))
                {
                    throw new Exception("Valor del rut no puede ser vacio");
                }


                ServicioCliente sc = new ServicioCliente();
                int res = sc.AddEntity(clientetest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        [TestMethod()]
        public void AgregarClienteSinExitoYaExiste()
        {
            try
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
                int res = sc.AddEntity(clientetest);

            }
            catch (Exception ex)
            {
                throw (ex);



            }

        }

        /// <summary>
        /// //Pruebas Unitarias a Metodo DeleteEntity
        /// 
        [TestMethod()]
        public void EliminarClienteconExito()
        {
            try
            {
                //PRUEBA EXITOSA- Eliminar el cliente 666  de la  bd.
                Cliente clientetest = new Cliente();

                clientetest.RutCliente = "636";
                clientetest.RazonSocial = "Servicio";
                clientetest.NombreContacto = "Juanito";
                clientetest.MailContacto = "juan@hotmail.com";
                clientetest.Telefono = "23243254";
                clientetest.Direccion = "calle mermelada 123";
                clientetest.IdTipoEmpresa = 10;
                clientetest.IdActividadEmpresa = 1;

                ServicioCliente sc = new ServicioCliente();
                int res = sc.DeleteEntity(clientetest.RutCliente);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }

        [TestMethod()]
        public void EliminarClientesinExito_noExiste()
        {
            try
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
                int res = sc.DeleteEntity(clientetest.RutCliente);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }

        public void EliminarClientesinExitoFaltaDato()
        {
            try
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

                if (string.IsNullOrEmpty(clientetest.RutCliente))
                {
                    throw new Exception("Valor del rut no puede ser vacio");
                }

                ServicioCliente sc = new ServicioCliente();
                int res = sc.DeleteEntity(clientetest.RutCliente);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        /// <summary>
        // Creacion de pruebas Unitarias en metodo  Uppdate cliente
        // </summary>
        [TestMethod()]
        public void ActualizarclienteconExito()
        {
            try
            {
                // PRUEBA EXITOSA-Actualizar cliente ya existente
                Cliente clientetest = new Cliente();


                clientetest.RutCliente = "636";
                clientetest.RazonSocial = "Frutos del bosque";
                clientetest.NombreContacto = "Juanito perez";
                clientetest.MailContacto = "frutos@hotmail.com";
                clientetest.Telefono = "444444445";
                clientetest.Direccion = "calle mermelada 123";
                clientetest.IdTipoEmpresa = 10;
                clientetest.IdActividadEmpresa = 1;

                ServicioCliente sc = new ServicioCliente();
                int res = sc.UpdateEntity(clientetest);

            }
            catch (Exception ex)
            {
                throw (ex);



            }
        }



        [TestMethod()]
        public void ActualizarclienteSinExito()
        {
            try
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
                int res = sc.UpdateEntity(clientetest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }


        [TestMethod()]
        public void ActualizarclienteSinExitoDatoVacio()
        {
            try
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

                if (string.IsNullOrEmpty(clientetest.RutCliente))
                {
                    throw new Exception("Valor del rut no puede ser vacio");
                }

                ServicioCliente sc = new ServicioCliente();
                int res = sc.UpdateEntity(clientetest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }
    }
}


