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
    public class ServicioTipoEmpresaTests
    {
        [TestMethod()]
        public void AgregarTipoEmpresaConExito()
        {
         
                //PRUEBA EXITOSA- registar una nuevo tipo empresa

                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 50;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
               // Assert.ThrowsException<ArgumentException>(() => ste.AddEntity(tipoEmpresatest));



        }

        [TestMethod()]
        public void AgregarTipoEmpresasinExito()
        {
            
                //PRUEBA sin exito - ya se encuentra registrada en la base de datos
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 10;
                tipoEmpresatest.Descripcion = "SPA";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
               Assert.ThrowsException<ArgumentException>(() => ste.AddEntity(tipoEmpresatest));



        }


        [TestMethod()]
        public void AgregarTipoEmpresasinExitovacio()
        {
           
                //PRUEBA sin exito - ya se encuentra un dato vacio
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = -1;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";


              
                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
               
               Assert.ThrowsException<ArgumentException>(() => ste.AddEntity(tipoEmpresatest));


        }


        /// <summary>
        /// Creacion de pruebas unitarias a metodo actualizar tipo empresa 
        /// </summary>
      
        [TestMethod()]
        public void CambiarConExitoTipoEmpresa()
        {
          
                //PRUEBA EXITOSA- Actualizar tipo empresa
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 50;
                tipoEmpresatest.Descripcion = "SOC. CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
                //Assert.ThrowsException<ArgumentException>(() => ste.UpdateEntity(tipoEmpresatest));





        }


        [TestMethod()]
        public void CambiarSinExitoTipoEmpresaNoExiste()
        {
              //PRUEBA sin exito  Actualizar tipo empresa que no existe 
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 70;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
                Assert.ThrowsException<ArgumentException>(() => ste.UpdateEntity(tipoEmpresatest));



        }

        [TestMethod()]
        public void CambiarSinExitoTipoEmpresaVacio()
        {
            
               // PRUEBA sin exito  Actualizar tipo empresa con campo vacio  
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = -1;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";

            


                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        
            Assert.ThrowsException<ArgumentException>(() => ste.UpdateEntity(tipoEmpresatest));



        }
        /// <summary>
        /// Pruebas Unitarias a metodo Eliminar Tipo de empresa 
        /// </summary>
        [TestMethod()]
        public void EliminarTipoEmpresaConExito()
        {
              //PRUEBA EXITOSA- Eliminar tipo empresa
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 50;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
                
             // Assert.ThrowsException<ArgumentException>(() => ste.DeleteEntity(tipoEmpresatest.IdTipoEmpresa));

         
        }

        [TestMethod()]
        public void EliminarTipoEmpresaSinExitoNoexiste()
        {
          
                //PRUEBA no exitosa - al eliminar una tipo de empresa no existente
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 50;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
                Assert.ThrowsException<ArgumentException>(() => ste.DeleteEntity(tipoEmpresatest.IdTipoEmpresa));

        

        }

        [TestMethod()]
        public void EliminarTipoEmpresaSinExitovacio()
        {
           
                //PRUEBA no exitosa - al eliminar una tipo de empresa con dato vacio 
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = -1;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
                Assert.ThrowsException<ArgumentException>(() => ste.DeleteEntity(tipoEmpresatest.IdTipoEmpresa));

          

        }
    }


}