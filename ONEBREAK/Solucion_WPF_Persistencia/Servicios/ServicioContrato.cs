using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios
{
    public class ServicioContrato : AbstractService<Contrato>
    {

        public override void AddEntity(Contrato entity)
        {


            // Crear Contrato
            Contrato contrato = GetEntity(entity.Numero);
            if (contrato == null)
            {
              
                em.Contrato.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el Contrato");
            }





        }

        public override List<Contrato> GetEntities()
        {
            return em.Contrato.ToList<Contrato>();
        }

        public override void DeleteEntity(object key)
        {

            Contrato contrato = GetEntity(key);
            if (contrato != null)
            {
                em.Contrato.Remove(contrato);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar Contrato , debido a que existe o esta relacionado  ");

            }
        }
        /// <summary>
        /// //////////////////////////////
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override Contrato GetEntity(object key)
        {
            //throw new NotImplementedException();
            return em.Contrato.Where(a => a.Numero == (String)key).FirstOrDefault<Contrato>();
        }

        public override List<Contrato> GetEntity()
        {
            //throw new NotImplementedException();
            return em.Contrato.ToList<Contrato>();
        }

        public override void UpdateEntity(Contrato entity)
        {
            //throw new NotImplementedException();
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


                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de Contrato");
            }
        }

    }

}
