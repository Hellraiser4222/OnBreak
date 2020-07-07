using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;
using Servicios;

namespace Servicios
{
    public class ServicioTipoEvento : AbstractService<TipoEvento>
    {
        public override int AddEntity(TipoEvento entity)
        {

            int res = 1;
            // Crear TipoEvento
            TipoEvento Tipo_Evento = GetEntity(entity.IdTipoEvento);
            if (Tipo_Evento == null)
            {

                em.TipoEvento.Add(entity);
                //Guardar Cambios
                res=em.SaveChanges();

            }
            else
            {
                res = -1;
                throw new ArgumentException("No se logro Registrar el Tipo de Evento, debido a que ya existe");
            }
            return res;





        }

        public override List<TipoEvento> GetEntities()
        {
            return em.TipoEvento.ToList<TipoEvento>();
        }

        public override int DeleteEntity(object key)
        {
            int res = 1;
            TipoEvento Tipo_Evento = GetEntity(key);
            if (Tipo_Evento != null)
            {
                em.TipoEvento.Remove(Tipo_Evento);
                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede Eliminar Tipo Evento , debido a que no existe ");

            }
            return res;
        }

        public override TipoEvento GetEntity(object key)
        {
            
            return em.TipoEvento.Where(a => a.IdTipoEvento == (int)key).FirstOrDefault<TipoEvento>();
        }

        public override List<TipoEvento> GetEntity()
        {
            
            return em.TipoEvento.ToList<TipoEvento>();
        }

        public override int UpdateEntity(TipoEvento entity)
        {
            int res = 1;
            TipoEvento Tipo_Evento = GetEntity(entity.IdTipoEvento);
            if (Tipo_Evento != null)
            {

                Tipo_Evento.Descripcion = entity.Descripcion;
                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede actualizar los Datos De Tipo de Evento, debido a que no existe");
            }
            return res;




        }
    }
}
