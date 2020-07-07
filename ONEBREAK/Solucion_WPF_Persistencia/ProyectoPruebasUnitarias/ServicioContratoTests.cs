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
    public class ServicioContratoTests
    {
        /// <summary>
        /// Pruebas ADD Entity Contrato
        /// </summary>
        [TestMethod()]
        public void AgregarContratoConExito()
        {
            try
            {
                //PRUEBA EXITOSA- registar un nuevo contrato en la bd.
               Contrato Contratotest = new Contrato();
                //Falta Ver EL tema de fechas
               // Contratotest.Creacion = ;
               // Contratotest.Termino = ;
                Contratotest.RutCliente = "2011133342";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
              //  Contratotest.FechaHoraInicio = ;
              //  Contratotest.FechaHoraTermino = ;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 2;
                Contratotest.Realizado = true;
                Contratotest.ValorTotalContrato = 1222222;
                Contratotest.Observaciones = "Evento Ejecutivos";

                ServicioContrato sco = new ServicioContrato();
                int res = sco.AddEntity(Contratotest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
    }
}