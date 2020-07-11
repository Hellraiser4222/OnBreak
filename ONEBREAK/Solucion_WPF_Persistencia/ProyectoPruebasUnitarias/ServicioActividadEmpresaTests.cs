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
    public class ServicioActividadEmpresaTests
    {
        [TestMethod()]
        public void AgregarActividadEmpresaConExito()
        {
           
           
                //PRUEBA EXITOSA- registar una nuevo actividad empresa
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 9;
                actividadtest.Descripcion = "Pescaderia";

                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
        
              //  Assert.ThrowsException<ArgumentException>(() => sa.AddEntity(actividadtest));




        }

        [TestMethod()]
        public void AgregarActividadEmpresaSinExitoVacio()
        {
            
            

                //PRUEBA CON ERROR - NO SE GRABA PORQUE FALTA CAMPO OBLIGATORIO
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = -1;
                actividadtest.Descripcion = "Pescaderia";


              ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
            Assert.ThrowsException<ArgumentException>(() => sa.AddEntity(actividadtest));


        }


        [TestMethod()]
        public void AgregarActividadEmpresaSinExitoYaExiste()
        {
          

                //PRUEBA CON ERROR - NO SE GRABA PORQUE FALTA CAMPO OBLIGATORIO
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 4;
                actividadtest.Descripcion = "Comercio";


                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                Assert.ThrowsException<ArgumentException>(() => sa.AddEntity(actividadtest));


        }


        /// <summary>
        /// Actividad Empresa metodo Actualizar
        /// </summary>
        [TestMethod()]
        public void CambiarActividadEmpresaConExito()
        {
            
                //PRUEBA EXITOSA- registar una nuevo actividad empresa
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 9;
                actividadtest.Descripcion = "Pasteleria";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
          
               // Assert.ThrowsException<ArgumentException>(() => sa.UpdateEntity(actividadtest));

        }


        [TestMethod()]
        public void CambiarActividadEmpresaSinExitoNoexiste()
        {
           
            
            //PRUEBA no existosa : Actualizar actividad de empresa no existente 
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 20;
                actividadtest.Descripcion = "Pasteleria";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                
                Assert.ThrowsException<ArgumentException>(() => sa.UpdateEntity(actividadtest));
         

        }

        [TestMethod()]
        public void CambiarActividadEmpresaSinExitovacio()
        {
           
                //PRUEBA no existosa : Actualizar actividad de empresa con campo vacio
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = -1;
                actividadtest.Descripcion = "Pasteleria";

                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                Assert.ThrowsException<ArgumentException>(() => sa.UpdateEntity(actividadtest));


        }
        /// <summary>
        /// Creacion de pruebas unitarias Metodo Eliminar Actividad Empresa
        /// </summary>
        [TestMethod()]
        public void EliminarActividadEmpConExito()
        {
          
                //PRUEBA EXITOSA- Eliminar actividad empresa
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 9;
                actividadtest.Descripcion = "Pasteleria";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
           
               // Assert.ThrowsException<ArgumentException>(() => sa.DeleteEntity(actividadtest.IdActividadEmpresa));



        }

        [TestMethod()]
        public void EliminarActividadEmpSinExitoVacio()
        {
           
                //PRUEBA no  EXITOSA- Eliminar actividad empresa con campo vacio 
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = -1;
                actividadtest.Descripcion = "Pescaderia";

               
                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                Assert.ThrowsException<ArgumentException>(() => sa.DeleteEntity(actividadtest.IdActividadEmpresa));
        }
           
        

        [TestMethod()]
        public void EliminarActividadEmpSinExitoNoExiste()
        {
         
                //PRUEBA no  EXITOSA- Eliminar actividad empresa con campo vacio 
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 30;
                actividadtest.Descripcion = "Pescaderia";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                Assert.ThrowsException<ArgumentException>(() => sa.DeleteEntity(actividadtest.IdActividadEmpresa));

        }
           
            

 }  }