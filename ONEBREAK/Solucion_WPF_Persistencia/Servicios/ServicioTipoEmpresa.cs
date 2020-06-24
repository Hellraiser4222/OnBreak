using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios
{
    public class ServicioTipoEmpresa : AbstractService<TipoEmpresa>
    {
        public override void AddEntity(TipoEmpresa entity)
        {


            // Crear TipoEmpresa
            TipoEmpresa Tipo_Empresa = GetEntity(entity.IdTipoEmpresa);
            if (Tipo_Empresa == null)
            {

                em.TipoEmpresa.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el Tipo Empresa");
            }





        }
        public override List<TipoEmpresa> GetEntities()
        {
            return em.TipoEmpresa.ToList<TipoEmpresa>();
        }

        public override void DeleteEntity(object key)
        {

            TipoEmpresa TipoEmpresa = GetEntity(key);
            if (TipoEmpresa != null)
            {
                em.TipoEmpresa.Remove(TipoEmpresa);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar TipoEmpresa , debido a que existe o esta relacionado  ");

            }
        }
        
        public override TipoEmpresa GetEntity(object key)
        {
            //throw new NotImplementedException();
            return em.TipoEmpresa.Where(a => a.IdTipoEmpresa == (int)key).FirstOrDefault<TipoEmpresa>();
        }

        public override List<TipoEmpresa> GetEntity()
        {
            //throw new NotImplementedException();
            return em.TipoEmpresa.ToList<TipoEmpresa>();
        }

        public override void UpdateEntity(TipoEmpresa entity)
        {
            TipoEmpresa Tipo_Empresa = GetEntity(entity.IdTipoEmpresa);
            if (Tipo_Empresa != null)
            {

                Tipo_Empresa.Descripcion = entity.Descripcion;
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos De Tipo de Empresa");
            }
           
                


        }
    }
}
