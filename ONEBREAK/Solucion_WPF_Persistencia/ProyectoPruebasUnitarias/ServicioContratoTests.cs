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
        // <summary>
        // Pruebas ADD Entity Contrato
        // </summary>
        [TestMethod()]
        public void AgregarContratoConExito()
        {

            DateTime fecha = new DateTime(2020, 11, 12);
            DateTime fecha1 = new DateTime(2020, 12, 12);
            DateTime time = new DateTime(2020, 11, 16, 12, 30, 3);
            DateTime time1 = new DateTime(2020, 11, 16, 22, 30, 3);
            try
            {
                //PRUEBA EXITOSA- registar un nuevo contrato en la bd.
                Contrato Contratotest = new Contrato();

                Contratotest.Numero = "1";
                Contratotest.Creacion = fecha;
                Contratotest.Termino = fecha1;
                Contratotest.RutCliente = "201113334";
                Contratotest.IdModalidad = "CB001";
                Contratotest.IdTipoEvento = 10;
                Contratotest.FechaHoraInicio = time;
                Contratotest.FechaHoraTermino = time1;
                Contratotest.Asistentes = 10;
                Contratotest.PersonalAdicional = 3;
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