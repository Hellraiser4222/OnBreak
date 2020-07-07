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
            try
            {
                //PRUEBA EXITOSA- registar una nueva Modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                int res = sm.AddEntity(Modalidadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
   

    [TestMethod()]
    public void AgregarModalidadsinExitoFaltaDatos()
    {
        try
        {
            //PRUEBA sin exito Por falta de datos
            ModalidadServicio Modalidadtest = new ModalidadServicio();

            Modalidadtest.IdModalidad = "";
            Modalidadtest.Nombre = "Matrimonio";
            Modalidadtest.IdTipoEvento = 20;
            Modalidadtest.ValorBase = 2000000;
            Modalidadtest.PersonalBase = 35;





            if (string.IsNullOrEmpty(Modalidadtest.IdModalidad))
            {
                throw new Exception("Valor del modalidad no puede ser vacio");
            }


            ServicioModalidadServicio sm = new ServicioModalidadServicio();
            int res = sm.AddEntity(Modalidadtest);

        }
        catch (Exception ex)
        {
            throw (ex);

        }
    } 
    

    [TestMethod()]
    public void AgregarModalidadiSinExitoYaExiste()
    {
        try
        {
            //PRUEBA sin exito por que ya existe 
            ModalidadServicio Modalidadtest = new ModalidadServicio();

            Modalidadtest.IdModalidad = "CA001";
            Modalidadtest.Nombre = "Matrimonio";
            Modalidadtest.IdTipoEvento = 20;
            Modalidadtest.ValorBase = 2000000;
            Modalidadtest.PersonalBase = 35;





    

            ServicioModalidadServicio sm = new ServicioModalidadServicio();
            int res = sm.AddEntity(Modalidadtest);

        }
        catch (Exception ex)
        {
            throw (ex);

        }
    }
}
   }