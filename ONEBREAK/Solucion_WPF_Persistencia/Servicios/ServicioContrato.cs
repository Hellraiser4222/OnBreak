using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;
using Servicios;

namespace Servicios
{
    public class ServicioContrato : AbstractService<Contrato>
    {

        public override int AddEntity(Contrato entity)
        {
            int res = 1;

            // Crear Contrato
            Contrato contrato = GetEntity(entity.Numero);
            if (contrato == null)
            {
              
                em.Contrato.Add(entity);
                //Guardar Cambios
                res=em.SaveChanges();

            }
            else
            {
                res = -1;
                throw new ArgumentException("No se logro Registrar el Contrato");
            }
            return res;




        }

        public override List<Contrato> GetEntities()
        {
            return em.Contrato.ToList<Contrato>();
        }

        public override int DeleteEntity(object key)
        {
            int res = 1;
            Contrato contrato = GetEntity(key);
            if (contrato != null)
            {
                em.Contrato.Remove(contrato);
                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede Eliminar Contrato , debido a que existe o esta relacionado  ");

            }
            return res;
        }
       

        public override Contrato GetEntity(object key)
        {
          
            return em.Contrato.Where(a => a.Numero == (String)key).FirstOrDefault<Contrato>();
        }

        public override List<Contrato> GetEntity()
        {
          
            return em.Contrato.ToList<Contrato>();
        }

        public override int UpdateEntity(Contrato entity)
        {
            int res = 1;
            Contrato contrato = GetEntity(entity.Numero);
            if (contrato != null)
            {
                contrato.Creacion = entity.Creacion;
                contrato.Termino = entity.Termino;
                contrato.RutCliente = entity.RutCliente;
                contrato.IdModalidad = entity.IdModalidad;
                contrato.IdTipoEvento = entity.IdTipoEvento;
                contrato.FechaHoraInicio = entity.FechaHoraInicio;
                contrato.FechaHoraTermino = entity.FechaHoraTermino;
                contrato.Asistentes = entity.Asistentes;
                contrato.PersonalAdicional = entity.PersonalAdicional;
                contrato.Realizado = entity.Realizado;
                contrato.ValorTotalContrato = entity.ValorTotalContrato;
                contrato.Observaciones = entity.Observaciones;


                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede actualizar los Datos de Contrato");
            }
            return res;
        }

    }

}
