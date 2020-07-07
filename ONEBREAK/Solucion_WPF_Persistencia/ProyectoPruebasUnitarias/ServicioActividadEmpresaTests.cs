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
                try
                {
                    //PRUEBA EXITOSA- registar una nuevo actividad empresa
                 ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 9;
                actividadtest.Descripcion = "Pescaderia";
              


                   ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                    int res = sa.AddEntity(actividadtest);

                }
                catch (Exception ex)
                {
                    throw (ex);

                }

            }

        //[TestMethod()]
        //public void AgregarActividadEmpresaConExito()
        //{
        //    try
        //    {

        //        PRUEBA CON ERROR - NO SE GRABA PORQUE FALTA CAMPO OBLIGATORIO
        //        ActividadEmpresa actividadtest = new ActividadEmpresa();

        //        actividadtest.IdActividadEmpresa = ;
        //        actividadtest.Descripcion = "Pescaderia";



                //    if (int.IsNullOrEmpty(actividadtest.IdActividadEmpresa))
                //    {
                //        throw new Exception("el Id de actividad empresa   no puede ser vacio");
                //    }


                //    ServicioCliente sc = new ServicioCliente();
                //    int res = sc.AddEntity(actividadtest);

                //}
                //catch (Exception ex)
                //{
                //    throw (ex);

                //}
                //}


            }
}