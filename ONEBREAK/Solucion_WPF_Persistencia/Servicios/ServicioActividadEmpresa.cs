using PersistenciaBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios
{
    public class ServicioActividadEmpresa : AbstractService<ActividadEmpresa>
    {
        public override void AddEntity(ActividadEmpresa entity)
        {
            // throw new NotImplementedException();

            // Crear Actividad.Empresa
            ActividadEmpresa actividad_Empresa = GetEntity(entity.IdActividadEmpresa);
            if (actividad_Empresa == null)
            {
                // Insertar una actividad empresa
                em.ActividadEmpresa.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar La activividad de la Empresa");
            }
       
        }

        public override List<ActividadEmpresa> GetEntities()
        {
            return em.ActividadEmpresa.ToList<ActividadEmpresa>();
        }

        public override void DeleteEntity(object key)
        {
            //throw new NotImplementedException();
            ActividadEmpresa actividad_Empresa = GetEntity(key);
            if(actividad_Empresa!= null)
            {
                em.ActividadEmpresa.Remove(actividad_Empresa);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar La Actividad de la empresa, debido a que existe o esta relacionado con un Cliente ");

            }
        }

        public override ActividadEmpresa GetEntity(object key)
        {
            //throw new NotImplementedException();
            return em.ActividadEmpresa.Where(a => a.IdActividadEmpresa == (int)key).FirstOrDefault<ActividadEmpresa>();
        }

        public override List<ActividadEmpresa> GetEntity()
        {
            //throw new NotImplementedException();
            return em.ActividadEmpresa.ToList<ActividadEmpresa>();
        }

        public override void UpdateEntity(ActividadEmpresa entity)
        {
            //throw new NotImplementedException();
            ActividadEmpresa actividad_Empresa = GetEntity(entity.IdActividadEmpresa);
            if(actividad_Empresa != null)
            {
                actividad_Empresa.Descripcion = entity.Descripcion;
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de la Actividad de la Empresa");
            }
        }
    }
}
