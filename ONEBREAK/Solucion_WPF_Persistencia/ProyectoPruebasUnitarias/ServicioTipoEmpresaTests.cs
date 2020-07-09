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
        //[TestMethod()]
        //public void AgregarTipoEmpresaConExito()
        //{
        //    try
        //    {
        //        //PRUEBA EXITOSA- registar una nuevo tipo empresa
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = 50;
        //        tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.AddEntity(tipoEmpresatest);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }

        //}

        //[TestMethod()]
        //public void AgregarTipoEmpresasinExito()
        //{
        //    try
        //    {
        //        //PRUEBA sin exito - ya se encuentra registrada en la base de datos
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = 50;
        //        tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.AddEntity(tipoEmpresatest);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }

        //}


        //[TestMethod()]
        //public void AgregarTipoEmpresasinExitovacio()
        //{
        //    try
        //    {
        //        //PRUEBA sin exito - ya se encuentra un dato vacio
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = -1;
        //        tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";


        //        if (tipoEmpresatest.IdTipoEmpresa <= -1)
        //        {
        //            throw new Exception("Valor del tipo de empresa no puede ser vacio debe ser un numero mayor");
        //        }



        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.AddEntity(tipoEmpresatest);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }

        //}


        ///// <summary>
        ///// Creacion de pruebas unitarias a metodo actualizar tipo empresa 
        ///// </summary>
        //[TestMethod()]
        //public void ActualizarConExitoTipoEmpresa()
        //{
        //    try
        //    {
        //        //PRUEBA EXITOSA- Actualizar tipo empresa
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = 50;
        //        tipoEmpresatest.Descripcion = "SOC. CIVIL";



        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.UpdateEntity(tipoEmpresatest);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }


        //}


        //[TestMethod()]
        //public void ActualizarSinExitoTipoEmpresaNoExiste()
        //{
        //    try
        //    {
        //        //PRUEBA sin exito  Actualizar tipo empresa que no existe 
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = 70;
        //        tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.UpdateEntity(tipoEmpresatest);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }


        //}

        [TestMethod()]
        public void ActualizarSinExitoTipoEmpresaVacio()
        {
            
                //PRUEBA sin exito  Actualizar tipo empresa con campo vacio  
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = -1;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";

            


                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        
            Assert.ThrowsException<ArgumentException>(() => ste.UpdateEntity(tipoEmpresatest));



        }
        ///// <summary>
        ///// Pruebas Unitarias a metodo Eliminar Tipo de empresa 
        ///// </summary>
        //[TestMethod()]
        //public void EliminarTipoEmpresaConExito()
        //{
        //    try
        //    {
        //        //PRUEBA EXITOSA- Eliminar tipo empresa
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = 50;
        //        tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.DeleteEntity(tipoEmpresatest.IdTipoEmpresa);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }

        //}

        //[TestMethod()]
        //public void EliminarTipoEmpresaSinExitoNoexiste()
        //{
        //    try
        //    {
        //        //PRUEBA no exitosa - al eliminar una tipo de empresa no existente
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = 50;
        //        tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.DeleteEntity(tipoEmpresatest.IdTipoEmpresa);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }

        //}

        //[TestMethod()]
        //public void EliminarTipoEmpresaSinExitovacio()
        //{
        //    try
        //    {
        //        //PRUEBA no exitosa - al eliminar una tipo de empresa con dato vacio 
        //        TipoEmpresa tipoEmpresatest = new TipoEmpresa();

        //        tipoEmpresatest.IdTipoEmpresa = -1;
        //        tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";


        //        if (tipoEmpresatest.IdTipoEmpresa <= -1)
        //        {
        //            throw new Exception("Valor del tipo Empresa  no puede ser vacio debe ser  un numero mayor");
        //        }

        //        ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
        //        int res = ste.DeleteEntity(tipoEmpresatest.IdTipoEmpresa);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);

        //    }

        //}
    }


}