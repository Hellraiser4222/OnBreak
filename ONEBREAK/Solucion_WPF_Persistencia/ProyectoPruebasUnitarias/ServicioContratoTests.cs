﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios.Tests
{
    [TestClass()]
    public class ServicioContratoTests
    {
        // <summary>
        // Pruebas ADD Entity Contrato
        // </summary>
        [TestMethod()]
        public void AgregarContratoConExito()
        {

            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
         
                //PRUEBA EXITOSA- registar un nuevo contrato en la bd.
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "4";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 3;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 1222222;
                Contratotest.Observaciones = "Evento Ejecutivos";

                ServicioContrato sco = new ServicioContrato();
                
               //Assert.ThrowsException<ArgumentException>(() => sco.AddEntity(Contratotest));

        }



        [TestMethod()]
        public void AgregarContratosinExitoyaexiste()
        {

            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
            
                //prueba sin exito ya que contrato ya se encuentra registrado
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "1";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 3;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 1222222;
                Contratotest.Observaciones = "Evento Ejecutivos";

                ServicioContrato sco = new ServicioContrato();
                Assert.ThrowsException<ArgumentException>(() => sco.AddEntity(Contratotest));


        }



        [TestMethod()]
        public void AgregarContratosinExitoDatovacio()
        {

            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
           
                //PRUEBA sin exito ya que contrato tien un dato vacio 
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 3;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 1222222;
                Contratotest.Observaciones = "Evento Ejecutivos";

              
                ServicioContrato sco = new ServicioContrato();
                Assert.ThrowsException<ArgumentException>(() => sco.AddEntity(Contratotest));


        }
        /// <summary>
        /// Creacion de pruebas unitarias en metodo eliminar contrato
        /// </summary>
        [TestMethod()]
        public void EliminarContratoConExito()
        {

            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
           
                //PRUEBA EXITOSA- Eliminar contrato
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "2";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 3;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 1222222;
                Contratotest.Observaciones = "Evento Ejecutivos";

                ServicioContrato sco = new ServicioContrato();
                //Assert.ThrowsException<ArgumentException>(() => sco.DeleteEntity(Contratotest.Numero));


        }


        [TestMethod()]
        public void EliminarContratosinExitonoExiste()
        {

            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);


              //prueba sin exito al eliminar contrato que no existe 
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "6";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 3;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 1222222;
                Contratotest.Observaciones = "Evento Ejecutivos";

                ServicioContrato sco = new ServicioContrato();
                Assert.ThrowsException<ArgumentException>(() => sco.DeleteEntity(Contratotest.Numero));
        }



        [TestMethod()]
        public void EliminarContratosinExitoDatovacio()
        {

            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
             //prueba sin exito al eliminar contrato con campo vacio 
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 3;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 1222222;
                Contratotest.Observaciones = "Evento Ejecutivos";
               


                ServicioContrato sco = new ServicioContrato();
                Assert.ThrowsException<ArgumentException>(() => sco.DeleteEntity(Contratotest.Numero));

         }

        /// <summary>
        /// Creacion de pruebas unitarias en actualizar contrato
        /// </summary>

        [TestMethod()]
        public void CambiarContratoExito()
        {
            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
           
                //PRUEBA EXITOSA- registar un nuevo contrato en la bd.
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "1";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 100;
                Contratotest.PersonalAdicional = 10;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 666666;
                Contratotest.Observaciones = "Evento Ejecutivos";

                ServicioContrato sco = new ServicioContrato();
             
                //Assert.ThrowsException<ArgumentException>(() => sco.UpdateEntity(Contratotest));



        }



        [TestMethod()]
        public void CambiarcontratoSinExitonoexiste()
        {
            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
           
                //PRUEBA sin exito -actualizar un contrato que no existe en la base de datos
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "5";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 10;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 4444444444;
                Contratotest.Observaciones = "Evento Ejecutivos";

                ServicioContrato sco = new ServicioContrato();
                Assert.ThrowsException<ArgumentException>(() => sco.UpdateEntity(Contratotest));


        }




            [TestMethod()]
        public void CambiarcontratoSinExitoVacio()
        {
            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
       
                //PRUEBA sin exito -actualizar un contrato que con dato vacio
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 10;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 4444444444;
                Contratotest.Observaciones = "Evento Ejecutivos";



                ServicioContrato sco = new ServicioContrato();
                Assert.ThrowsException<ArgumentException>(() => sco.UpdateEntity(Contratotest));



        }
    }
}