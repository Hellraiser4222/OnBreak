using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class ServicioModalidadServicioTests
    {
        [TestMethod()]
        public void AgregarModalidadConExito()
        {
          
                //PRUEBA EXITOSA- registar una nueva Modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                
               // Assert.ThrowsException<ArgumentException>(() => sm.AddEntity(Modalidadtest));

        }


        [TestMethod()]
        public void AgregarModalidadsinExitoFaltaDatos()
        {
           
                //PRUEBA sin exito Por falta de datos
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;






                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                Assert.ThrowsException<ArgumentException>(() => sm.AddEntity(Modalidadtest));

        
           
        }


        [TestMethod()]
        public void AgregarModalidadiSinExitoYaExiste()
        {
            
                //PRUEBA sin exito por que ya existe 
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CB002";
                Modalidadtest.Nombre = "Journal Break";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
               
                Assert.ThrowsException<ArgumentException>(() => sm.AddEntity(Modalidadtest));

        }
        /// <summary>
        /// Creacion de pruebas unitarias en Actualizar
        /// </summary>
        [TestMethod()]
        public void PruebaModalidadActualizarConExito()
        {
            
                //PRUEBA EXITOSA- Actualizar una Modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio ";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                
                //Assert.ThrowsException<ArgumentException>(() => sm.UpdateEntity(Modalidadtest));

        }

        [TestMethod()]
        public void PruebaModalidadActualizarsinExito()
        {
           
                //PRUEBA sin exito , no existe modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "D001";
                Modalidadtest.Nombre = "Talleres";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                Assert.ThrowsException<ArgumentException>(() => sm.UpdateEntity(Modalidadtest));

         
        }

        [TestMethod()]
        public void PruebaModalidadActualizarsinExitoFaltaCodigo()
        {
            
                //PRUEBA si exito , debido a que falta codigo 
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "";
                Modalidadtest.Nombre = "Matrimonio Civil";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
              
                Assert.ThrowsException<ArgumentException>(() => sm.UpdateEntity(Modalidadtest));


        }
        /// <summary>
        /// Creacion de pruebas en metodo Eliminar Modalidad
        /// </summary>
        [TestMethod()]
        public void EliminarModalidadConExito()
        {
                //PRUEBA EXITOSA-Se elimina Modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                
             //  Assert.ThrowsException<ArgumentException>(() => sm.DeleteEntity(Modalidadtest.IdModalidad));

        }

        [TestMethod()]
        public void EliminarModalidadSinExitonoExiste()
        {
          
                //PRUEBA sin exito -Se elimina Modalidad que no existe
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CD0001";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                Assert.ThrowsException<ArgumentException>(() => sm.DeleteEntity(Modalidadtest.IdModalidad));


        }


        [TestMethod()]
        public void EliminarModalidadSinExitovacio()
        {
           
                //PRUEBA sin exito -Se elimina Modalidad con campo vacio
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;

             

                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                Assert.ThrowsException<ArgumentException>(() => sm.DeleteEntity(Modalidadtest.IdModalidad));

        

        }
    }
}
