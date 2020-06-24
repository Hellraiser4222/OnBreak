using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios
{
    public class ServicioCliente : AbstractService<Cliente>
    {

        public override void AddEntity(Cliente entity)
        {
         

            // Crear Cliente
            Cliente cliente = GetEntity(entity.RutCliente);
            if (cliente == null)
            {
                // Insertar una actividad empresa
                em.Cliente.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el Cliente");
            }





        }

        public override List<Cliente> GetEntities()
        {
            return em.Cliente.ToList<Cliente>();
        }

        public override void DeleteEntity(object key)
        {
           
            Cliente cliente = GetEntity(key);
            if (cliente != null)
            {
                em.Cliente.Remove(cliente);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar Cliente , debido a que existe o esta relacionado  ");

            }
        }
        /// <summary>
        /// //////////////////////////////
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override Cliente GetEntity(object key)
        {
            //throw new NotImplementedException();
            return em.Cliente.Where(a => a.RutCliente == (string)key).FirstOrDefault<Cliente>();
        }

        public override List<Cliente> GetEntity()
        {
            //throw new NotImplementedException();
            return em.Cliente.ToList<Cliente>();
        }

        public override void UpdateEntity(Cliente entity)
        {
            //throw new NotImplementedException();
            Cliente cliente = GetEntity(entity.RutCliente);
            if (cliente != null)
            {
                cliente.NombreContacto = entity.NombreContacto;
                cliente.IdActividadEmpresa = entity.IdActividadEmpresa;
                cliente.IdTipoEmpresa = entity.IdTipoEmpresa;
                cliente.MailContacto = entity.MailContacto;
                cliente.Telefono = entity.Telefono;
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de Cliente");
            }
        }

    }
}