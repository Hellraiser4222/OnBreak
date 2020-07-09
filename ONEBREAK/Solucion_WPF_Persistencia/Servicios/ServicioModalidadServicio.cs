using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;
using Servicios;

namespace Servicios
{
    public class ServicioModalidadServicio : AbstractService<ModalidadServicio>
    {
        public override int  AddEntity(ModalidadServicio entity)
        {
            int res = 0;

            ModalidadServicio Modalidad_Servicio = GetEntity(entity.IdModalidad);
            if (Modalidad_Servicio == null)
            {
                // Insertar una actividad empresa
                em.ModalidadServicio.Add(entity);
                //Guardar Cambios
                res=em.SaveChanges();

            }
            else
            {
              
                throw new ArgumentException("No se logro Registrar La Modalidad de Servicio");
            }
            return res;





        }
        public override List<ModalidadServicio> GetEntities()
        {
            return em.ModalidadServicio.ToList<ModalidadServicio>();
        }

        public override int  DeleteEntity(object key)
        {
            int res = 0;
           
            ModalidadServicio Modalidad_Servicio = GetEntity(key);
            if (Modalidad_Servicio != null)
            {
                em.ModalidadServicio.Remove(Modalidad_Servicio);
                res=em.SaveChanges();
            }
            else
            {
                ;
                throw new ArgumentException("No se puede Eliminar la Modalidad de servicio, debido a que no existe o hay un campo vacio ");

            }
            return res;
        }

        public override ModalidadServicio GetEntity(object key)
        {
            
            return em.ModalidadServicio.Where(a => a.IdModalidad == (String)key).FirstOrDefault<ModalidadServicio>();
        }

        public override List<ModalidadServicio> GetEntity()
        {
            
            return em.ModalidadServicio.ToList<ModalidadServicio>();
        }

        public override int UpdateEntity(ModalidadServicio entity)
        {

            int res = 0;

            ModalidadServicio Modalidad_Servicio = GetEntity(entity.IdModalidad);
            if (Modalidad_Servicio != null)
            {
                Modalidad_Servicio.IdTipoEvento = entity.IdTipoEvento;
                Modalidad_Servicio.Nombre = entity.Nombre;
                Modalidad_Servicio.ValorBase = entity.ValorBase;
                Modalidad_Servicio.PersonalBase = entity.PersonalBase;
                res=em.SaveChanges();
            }
            else
            {
               
                throw new ArgumentException("No se puede actualizar los Datos de la Modalidad de Servicio, debido a que no existe o se encuentra un campo vacio");
            }
            return res;
        }
    }
}
