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



            /// <summary>
            /// //Pruebas Unitarias a Metodo DeleteEntity
            /// 
            //[TestMethod()]
            //public void EliminarClienteconExito()
            //{
            //    try
            //    {
            //        //PRUEBA EXITOSA- Eliminar el cliente 666  de la  bd.
            //        Cliente clientetest = new Cliente();
            //        clientetest.RutCliente = "666";
            //        clientetest.RazonSocial = "Servicio";
            //        clientetest.NombreContacto = "Juanito";
            //        clientetest.MailContacto = "juan@hotmail.com";
            //        clientetest.Telefono = "23243254";
            //        clientetest.Direccion = "calle mermelada 123";
            //        clientetest.IdTipoEmpresa = 10;
            //        clientetest.IdActividadEmpresa = 1;

            //        ServicioCliente sc = new ServicioCliente();
            //        int res = sc.DeleteEntity(clientetest);

            //    }
            //    catch (Exception ex)
            //    {
            //        throw (ex);

            //    }

            }
        }

    }
