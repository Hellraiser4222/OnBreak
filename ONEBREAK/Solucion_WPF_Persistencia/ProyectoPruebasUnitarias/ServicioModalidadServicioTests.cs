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
        /// <summary>
        /// Creacion de pruebas unitarias en Actualizar
        /// </summary>
        [TestMethod()]
        public void PruebaModalidadActualizarConExito()
        {
            try
            {
                //PRUEBA EXITOSA- Actualizar una Modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio Civil";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                int res = sm.UpdateEntity(Modalidadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }

        [TestMethod()]
        public void PruebaModalidadActualizarsinExito()
        {
            try
            {
                //PRUEBA sin exito , no existe modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "C001";
                Modalidadtest.Nombre = "Matrimonio Civil";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                int res = sm.UpdateEntity(Modalidadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }

        [TestMethod()]
        public void PruebaModalidadActualizarsinExitoFaltaCodigo()
        {
            try
            {
                //PRUEBA si exito , debido a que falta codigo 
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "";
                Modalidadtest.Nombre = "Matrimonio Civil";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                int res = sm.UpdateEntity(Modalidadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }
        /// <summary>
        /// Creacion de pruebas en metodo Eliminar Modalidad
        /// </summary>
        [TestMethod()]
        public void EliminarModalidadConExito()
        {
            try
            {
                //PRUEBA EXITOSA-Se elimina Modalidad
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                int res = sm.DeleteEntity(Modalidadtest.IdModalidad);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }

        [TestMethod()]
        public void EliminarModalidadSinExitonoExiste()
        {
            try
            {
                //PRUEBA sin exito -Se elimina Modalidad que no existe
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;


                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                int res = sm.DeleteEntity(Modalidadtest.IdModalidad);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        [TestMethod()]
        public void EliminarModalidadSinExitovacio()
        {
            try
            {
                //PRUEBA sin exito -Se elimina Modalidad con campo vacio
                ModalidadServicio Modalidadtest = new ModalidadServicio();

                Modalidadtest.IdModalidad = "CA001";
                Modalidadtest.Nombre = "Matrimonio";
                Modalidadtest.IdTipoEvento = 20;
                Modalidadtest.ValorBase = 2000000;
                Modalidadtest.PersonalBase = 35;

                if (string.IsNullOrEmpty(Modalidadtest.IdModalidad))
                {
                    throw new Exception("Valor del modalidad no puede ser vacio");
                }

                ServicioModalidadServicio sm = new ServicioModalidadServicio();
                int res = sm.DeleteEntity(Modalidadtest.IdModalidad);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
    }
}
