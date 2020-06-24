using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios
{
    public class ServicioTipoEvento : AbstractService<TipoEvento>
    {
        public override void AddEntity(TipoEvento entity)
        {


            // Crear TipoEvento
            TipoEvento Tipo_Evento = GetEntity(entity.IdTipoEvento);
            if (Tipo_Evento == null)
            {

                em.TipoEvento.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el Tipo de Evento");
            }





        }

        public override List<TipoEvento> GetEntities()
        {
            return em.TipoEvento.ToList<TipoEvento>();
        }

        public override void DeleteEntity(object key)
        {

            TipoEvento Tipo_Evento = GetEntity(key);
            if (Tipo_Evento != null)
            {
                em.TipoEvento.Remove(Tipo_Evento);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar Tipo Evento , debido a que existe o esta relacionado  ");

            }
        }

        public override TipoEvento GetEntity(object key)
        {
            //throw new NotImplementedException();
            return em.TipoEvento.Where(a => a.IdTipoEvento == (int)key).FirstOrDefault<TipoEvento>();
        }

        public override List<TipoEvento> GetEntity()
        {
            //throw new NotImplementedException();
            return em.TipoEvento.ToList<TipoEvento>();
        }

        public override void UpdateEntity(TipoEvento entity)
        {
            TipoEvento Tipo_Evento = GetEntity(entity.IdTipoEvento);
            if (Tipo_Evento != null)
            {

                Tipo_Evento.Descripcion = entity.Descripcion;
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos De Tipo de Evento");
            }




        }
    }
}
