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


        [TestMethod()]
        public void AgregarTipoEventoSinExitoYaExiste()
        {
            try
            {
                //PRUEBA no EXITOSA-  registrar un tipo evento que ya existe 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "Matrimonio";


                if (tipoEventotest.IdTipoEvento <= -1)
                {
                    throw new Exception("Valor del tipo evento no puede estar vacio debe contener un numero mayor");
                }

                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.AddEntity(tipoEventotest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        [TestMethod()]
        public void AgregarTipoEventoSinExitoVacio()
        {
            try
            {
                //PRUEBA no EXITOSA-  registrar un tipo evento que le falta un dato
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = -1;
                tipoEventotest.Descripcion = "Matrimonio";

                if (tipoEventotest.IdTipoEvento <= -1)
                {
                    throw new Exception("Valor del tipo de Evento no puede ser vacio debe  ser un numero entero mayor");
                }


                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.AddEntity(tipoEventotest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
        /// <summary>
        /// Crear pruebas unitarias a actualizar tipo de evento
        /// </summary>
        [TestMethod()]
        public void ActualizarTipoEventoExito()
        {
            try
            {
                //PRUEBA EXITOSA- Actualizar tipo evento
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "MATRIMONIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.UpdateEntity(tipoEventotest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
        [TestMethod()]
        public void ActualizarTipoEventoSinExitoVacio()
        {
            try
            {
                //PRUEBA  no EXITOSA- Actualizar tipo evento con campo vacio 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = -1;
                tipoEventotest.Descripcion = "Matrimonio Civil ";

                if (tipoEventotest.IdTipoEvento <= -1)
                {
                    throw new Exception("Valor del tipo de Evento no puede ser vacio debe  ser un numero entero mayor");
                }

                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.UpdateEntity(tipoEventotest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
        [TestMethod()]
        public void ActualizarTipoEventoSinExitoNoExiste()
        {
            try
            {
                //PRUEBA NO  EXITOSA- Actualizar tipo eventoQUE NO EXISTE 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 50;
                tipoEventotest.Descripcion = "ANIVERSARIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.UpdateEntity(tipoEventotest);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
        /// <summary>
        /// CREACION DE PRUEBAS UNITARIAS EN METODO ELIMINAR 
        /// </summary>
        [TestMethod()]
        public void EliminarConExitoTipoEvento()
        {
            try
            {
                //PRUEBA EXITOSA- Eliminar tipo evento
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "MATRIMONIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.DeleteEntity(tipoEventotest.IdTipoEvento);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        [TestMethod()]
        public void EliminarSinExitoTipoEventoVacio()
        {
            try
            {
                //PRUEBA no  EXITOSA- Eliminar tipo evento que no existe  
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = 40;
                tipoEventotest.Descripcion = "MATRIMONIO";



                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.DeleteEntity(tipoEventotest.IdTipoEvento);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }


        [TestMethod()]
        public void EliminarSinExitoTipoEventoSinDato()
        {
            try
            {
                //PRUEBA no EXITOSA- Eliminar tipo evento que tiene campo vacio 
                TipoEvento tipoEventotest = new TipoEvento();

                tipoEventotest.IdTipoEvento = -1;
                tipoEventotest.Descripcion = "MATRIMONIO";

                if (tipoEventotest.IdTipoEvento <= -1)
                {
                    throw new Exception("Valor del tipo de Evento no puede ser vacio debe  ser un numero entero mayor");
                }



                ServicioTipoEvento stev = new ServicioTipoEvento();
                int res = stev.DeleteEntity(tipoEventotest.IdTipoEvento);

            }
            catch (Exception ex)
            {
                throw (ex);

            }

        }
    }
}