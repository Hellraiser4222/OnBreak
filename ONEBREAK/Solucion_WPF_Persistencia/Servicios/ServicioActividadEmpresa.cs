﻿using PersistenciaBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using System.Data.SqlClient;

namespace Servicios
{
    public class ServicioActividadEmpresa : AbstractService<ActividadEmpresa>
    {
        public override int AddEntity(ActividadEmpresa entity)
        {

            int res = 0;
            // Crear Actividad.Empresa
            ActividadEmpresa actividad_Empresa = GetEntity(entity.IdActividadEmpresa);
            if (actividad_Empresa == null)
            {
                    // Insertar una actividad empresa
                    em.ActividadEmpresa.Add(entity);
                    //Guardar Cambios
                    res=em.SaveChanges();
                
             
               
            }
            else
            {
               
                throw new ArgumentException("No se logro Registrar La activividad de la Empresa, debido a que no existe ");
            }
            return res;

        }

        public override List<ActividadEmpresa> GetEntities()
        {
            return em.ActividadEmpresa.ToList<ActividadEmpresa>();
        }

        public override List<ActividadEmpresa> GetEntity()
        {
            ;
            return em.ActividadEmpresa.ToList<ActividadEmpresa>();
        }

        public override int DeleteEntity(object key)
        {
            int res = 0;
            ActividadEmpresa actividad_Empresa = GetEntity(key);
            if(actividad_Empresa!= null)
            {
                em.ActividadEmpresa.Remove(actividad_Empresa);
                res=em.SaveChanges();
            }
            else
            {
               
                throw new ArgumentException("No se puede Eliminar La Actividad de la empresa, debido a que no existe  ");

            }
            return res;
        }

        public override ActividadEmpresa GetEntity(object key)
        {
            return em.ActividadEmpresa.Where(a => a.IdActividadEmpresa == (int)key).FirstOrDefault<ActividadEmpresa>();
        }

     

        public override int UpdateEntity(ActividadEmpresa entity)
        {
           int res = 0;
            ActividadEmpresa actividad_Empresa = GetEntity(entity.IdActividadEmpresa);
            if(actividad_Empresa != null)
            {
                actividad_Empresa.Descripcion = entity.Descripcion;
                res=em.SaveChanges();
            }
            else
            {
               
                throw new ArgumentException("No se puede actualizar los Datos de la Actividad de la Empresa, debido a que no existe ");
            }
            return res;
        }
    }
}
