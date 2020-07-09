using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            int res = 0;

           
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
                
                throw new ArgumentException("No se logro Registrar el Contrato,contrato ya existente");
            }
            return res;




        }

        public override List<Contrato> GetEntities()
        {
            return em.Contrato.ToList<Contrato>();
        }

        public override int DeleteEntity(object key)
        {
            int res = 0;
            Contrato contrato = GetEntity(key);
            if (contrato != null)
            {
                if (string.IsNullOrEmpty((string)key))
                {
                    throw new ArgumentException("Valor del numero contrato no puede ser vacio");
                }

                em.Contrato.Remove(contrato);
                res=em.SaveChanges();
            }
            else
            {
               ;
                throw new ArgumentException("No se puede Eliminar Contrato , debido a que no  existe o hay un campo vacio  ");

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
            int res = 0;
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
             
                throw new ArgumentException("No se puede actualizar los Datos de Contrato,debido a que no existe ");
            }
            return res;
        }

    }

}
