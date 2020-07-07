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
            try
            {
                //PRUEBA EXITOSA- registar una nuevo tipo evento
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "Matrimonio";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.AddEntity(tipoEventotest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
    }
}