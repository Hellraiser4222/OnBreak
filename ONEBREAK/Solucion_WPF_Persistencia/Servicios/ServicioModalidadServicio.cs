using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios
{
    public class ServicioModalidadServicio : AbstractService<ModalidadServicio>
    {
        public override void AddEntity(ModalidadServicio entity)
        {
           
            ModalidadServicio Modalidad_Servicio = GetEntity(entity.IdModalidad);
            if (Modalidad_Servicio == null)
            {
                // Insertar una actividad empresa
                em.ModalidadServicio.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar La Modalidad de Servicio");
            }





        }
        public override List<ModalidadServicio> GetEntities()
        {
            return em.ModalidadServicio.ToList<ModalidadServicio>();
        }

        public override void DeleteEntity(object key)
        {
           
            ModalidadServicio Modalidad_Servicio = GetEntity(key);
            if (Modalidad_Servicio != null)
            {
                em.ModalidadServicio.Remove(Modalidad_Servicio);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar la Modalidad de servicio, debido a que existe o esta relacionado con un Cliente ");

            }
        }

        public override ModalidadServicio GetEntity(object key)
        {
            //verrrrrrrrrrrrrrrr
            return em.ModalidadServicio.Where(a => a.IdModalidad == (String)key).FirstOrDefault<ModalidadServicio>();
        }

        public override List<ModalidadServicio> GetEntity()
        {
            
            return em.ModalidadServicio.ToList<ModalidadServicio>();
        }

        public override void UpdateEntity(ModalidadServicio entity)
        {
            
            ModalidadServicio Modalidad_Servicio = GetEntity(entity.IdModalidad);
            if (Modalidad_Servicio != null)
            {
                Modalidad_Servicio.IdTipoEvento = entity.IdTipoEvento;
                Modalidad_Servicio.Nombre = entity.Nombre;
                Modalidad_Servicio.ValorBase = entity.ValorBase;
                Modalidad_Servicio.PersonalBase = entity.PersonalBase;
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de la Modalidad de Servicio");
            }
        }
    }
}
