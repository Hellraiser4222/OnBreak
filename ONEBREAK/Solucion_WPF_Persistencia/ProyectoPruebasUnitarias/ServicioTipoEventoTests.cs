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
    public class ServicioTipoEventoTests
    {
        [TestMethod()]
        public void AgregarTipoEventoConExito()
        {
                //PRUEBA EXITOSA- registar una nuevo tipo evento
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "Matrimonio";



                ServicioTipoEvento stev = new ServicioTipoEvento();
               
                //Assert.ThrowsException<ArgumentException>(() => stev.AddEntity(tipoEventotest));

        }


        [TestMethod()]
        public void AgregarTipoEventoSinExitoYaExiste()
        {
            
                //PRUEBA no EXITOSA-  registrar un tipo evento que ya existe 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 10;
                tipoEventotest.Descripcion = "Coffee Break";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                Assert.ThrowsException<ArgumentException>(() => stev.AddEntity(tipoEventotest));



        }


        [TestMethod()]
        public void AgregarTipoEventoSinExitoVacio()
        {
          
                //PRUEBA no EXITOSA-  registrar un tipo evento que le falta un dato
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = -1;
                tipoEventotest.Descripcion = "Matrimonio";

          


                ServicioTipoEvento stev = new ServicioTipoEvento();
                Assert.ThrowsException<ArgumentException>(() => stev.AddEntity(tipoEventotest));



            }
        /// <summary>
        /// Crear pruebas unitarias a actualizar tipo de evento
        /// </summary>
        [TestMethod()]
        public void CambiarTipoEventoExito()
        {
          
                //PRUEBA EXITOSA- Actualizar tipo evento
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "MATRIMONIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
               //Assert.ThrowsException<ArgumentException>(() => stev.UpdateEntity(tipoEventotest));
         
        }

        [TestMethod()]
        public void CambiarTipoEventoSinExitoVacio()
        {
          
                //PRUEBA  no EXITOSA- Actualizar tipo evento con campo vacio 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = -1;
                tipoEventotest.Descripcion = "Matrimonio Civil ";

             

                ServicioTipoEvento stev = new ServicioTipoEvento();
                Assert.ThrowsException<ArgumentException>(() => stev.UpdateEntity(tipoEventotest));


        }

        [TestMethod()]
        public void CambiarTipoEventoSinExitoNoExiste()
        {
           
                //PRUEBA NO  EXITOSA- Actualizar tipo eventoQUE NO EXISTE 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 50;
                tipoEventotest.Descripcion = "ANIVERSARIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                Assert.ThrowsException<ArgumentException>(() => stev.UpdateEntity(tipoEventotest));


            

        }
        /// <summary>
        /// CREACION DE PRUEBAS UNITARIAS EN METODO ELIMINAR 
        /// </summary>
        [TestMethod()]
        public void EliminarConExitoTipoEvento()
        {
               //PRUEBA EXITOSA- Eliminar tipo evento
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "MATRIMONIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
               //Assert.ThrowsException<ArgumentException>(() => stev.DeleteEntity(tipoEventotest));



        }


        [TestMethod()]
        public void EliminarSinExitoTipoEventoVacio()
        {
           
                //PRUEBA no  EXITOSA- Eliminar tipo evento que no existe  
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = -1;
                tipoEventotest.Descripcion = "MATRIMONIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                Assert.ThrowsException<ArgumentException>(() => stev.DeleteEntity(tipoEventotest.IdTipoEvento));



         }


        [TestMethod()]
        public void EliminarSinExitoTipoEventoNoExixte()
        {
              //PRUEBA no EXITOSA- Eliminar tipo evento que tiene campo vacio 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 80;
                tipoEventotest.Descripcion = "Baby Shower";

              


                ServicioTipoEvento stev = new ServicioTipoEvento();
              Assert.ThrowsException<ArgumentException>(() => stev.DeleteEntity(tipoEventotest.IdTipoEvento));



        }
    }
}