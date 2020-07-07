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

        [TestMethod()]
        public void AgregarActividadEmpresaSinExitoVacio()
        {
            try
            {

                //PRUEBA CON ERROR - NO SE GRABA PORQUE FALTA CAMPO OBLIGATORIO
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = -1;
                actividadtest.Descripcion = "Pescaderia";


                if (actividadtest.IdActividadEmpresa <= -1)
                {
                    throw new Exception("Valor del Actividad empresa no puede ser vacio debe ser un numero mayor");
                }

                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                int res = sa.AddEntity(actividadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }


        [TestMethod()]
        public void AgregarActividadEmpresaSinExitoYaExiste()
        {
            try
            {

                //PRUEBA CON ERROR - NO SE GRABA PORQUE FALTA CAMPO OBLIGATORIO
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


        /// <summary>
        /// Actividad Empresa metodo Actualizar
        /// </summary>
        [TestMethod()]
        public void ActualizarActividadEmpresaConExito()
        {
            try
            {
                //PRUEBA EXITOSA- registar una nuevo actividad empresa
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 9;
                actividadtest.Descripcion = "Pasteleria";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                int res = sa.UpdateEntity(actividadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        [TestMethod()]
        public void ActualizarActividadEmpresaSinExitoNoexiste()
        {
            try
            {
                //PRUEBA no existosa : Actualizar actividad de empresa no existente 
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 20;
                actividadtest.Descripcion = "Pasteleria";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                int res = sa.UpdateEntity(actividadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }

        [TestMethod()]
        public void ActualizarActividadEmpresaSinExitovacio()
        {
            try
            {
                //PRUEBA no existosa : Actualizar actividad de empresa con campo vacio
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = -1;
                actividadtest.Descripcion = "Pasteleria";

                if (actividadtest.IdActividadEmpresa <= -1)
                {
                    throw new Exception("Valor del Actividad empresa no puede ser vacio debe ser un numero mayor");
                }


                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                int res = sa.UpdateEntity(actividadtest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
        /// <summary>
        /// Creacion de pruebas unitarias Metodo Eliminar Actividad Empresa
        /// </summary>
        [TestMethod()]
        public void EliminarActividadEmpConExito()
        {
            try
            {
                //PRUEBA EXITOSA- Eliminar actividad empresa
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 9;
                actividadtest.Descripcion = "Pescaderia";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                int res = sa.DeleteEntity(actividadtest.IdActividadEmpresa);

            }
            catch (Exception ex)
            {
                throw (ex);

            }


        }

        [TestMethod()]
        public void EliminarActividadEmpSinExitoVacio()
        {
            try
            {
                //PRUEBA no  EXITOSA- Eliminar actividad empresa con campo vacio 
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = -1;
                actividadtest.Descripcion = "Pescaderia";

                if (actividadtest.IdActividadEmpresa <= -1)
                {
                    throw new Exception("Valor del Actividad empresa no puede ser vacio debe ser un numero mayor");
                }


                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                int res = sa.DeleteEntity(actividadtest.IdActividadEmpresa);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        [TestMethod()]
        public void EliminarActividadEmpSinExitoNoExiste()
        {
            try
            {
                //PRUEBA no  EXITOSA- Eliminar actividad empresa con campo vacio 
                ActividadEmpresa actividadtest = new ActividadEmpresa();

                actividadtest.IdActividadEmpresa = 9;
                actividadtest.Descripcion = "Pescaderia";



                ServicioActividadEmpresa sa = new ServicioActividadEmpresa();
                int res = sa.DeleteEntity(actividadtest.IdActividadEmpresa);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
    }  }