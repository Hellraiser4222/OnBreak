using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;
using Servicios;

namespace Servicios
{
    public class ServicioTipoEmpresa : AbstractService<TipoEmpresa>
    {
        public override int AddEntity(TipoEmpresa entity)
        {

            int res = 1;
            // Crear TipoEmpresa
            TipoEmpresa Tipo_Empresa = GetEntity(entity.IdTipoEmpresa);
            if (Tipo_Empresa == null)
            {

                em.TipoEmpresa.Add(entity);
                //Guardar Cambios
                res=em.SaveChanges();

            }
            else
            {
                res = -1;
                throw new ArgumentException("No se logro Registrar el Tipo Empresa,debido a que ya existe");
            }
            return res;





        }
        public override List<TipoEmpresa> GetEntities()
        {
            return em.TipoEmpresa.ToList<TipoEmpresa>();
        }

        public override int  DeleteEntity(object key)
        {
            int res = 1;

            TipoEmpresa TipoEmpresa = GetEntity(key);
            if (TipoEmpresa != null)
            {
                em.TipoEmpresa.Remove(TipoEmpresa);
                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede Eliminar Tipo Empresa , debido a que no  existe o hay un campo vacio ");

            }
            return res;
        }
        
        public override TipoEmpresa GetEntity(object key)
        {
            
            return em.TipoEmpresa.Where(a => a.IdTipoEmpresa == (int)key).FirstOrDefault<TipoEmpresa>();
        }

        public override List<TipoEmpresa> GetEntity()
        {
           
            return em.TipoEmpresa.ToList<TipoEmpresa>();
        }

        public override int UpdateEntity(TipoEmpresa entity)
        {
            int res = 1;
            TipoEmpresa Tipo_Empresa = GetEntity(entity.IdTipoEmpresa);
            if (Tipo_Empresa != null)
            {

                Tipo_Empresa.Descripcion = entity.Descripcion;
                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede actualizar los Datos De Tipo de Empresa, Ya que no existe ");
            }
            return res;




        }
    }
}
