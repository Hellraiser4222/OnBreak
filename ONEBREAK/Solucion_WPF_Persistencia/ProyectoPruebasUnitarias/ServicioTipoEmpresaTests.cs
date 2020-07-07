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
            try
            {
                //PRUEBA EXITOSA- registar una nuevo tipo empresa
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 50;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
                int res = ste.AddEntity(tipoEmpresatest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }

        [TestMethod()]
        public void AgregarTipoEmpresasinExito()
        {
            try
            {
                //PRUEBA sin exito - ya se encuentra registrada
                TipoEmpresa tipoEmpresatest = new TipoEmpresa();

                tipoEmpresatest.IdTipoEmpresa = 50;
                tipoEmpresatest.Descripcion = "SOCIEDAD CIVIL";



                ServicioTipoEmpresa ste = new ServicioTipoEmpresa();
                int res = ste.AddEntity(tipoEmpresatest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
    }
}