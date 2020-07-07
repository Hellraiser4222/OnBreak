using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios
{
    public class ServicioCliente : AbstractService<Cliente>
    {

        public override int AddEntity(Cliente entity)
        {

            int res = 0;
            // Crear Cliente
            Cliente cliente = GetEntity(entity.RutCliente);
            if (cliente == null)
            {
                try
                {
                    // Insertar una actividad empresa
                    em.Cliente.Add(entity);
                    //Guardar Cambios
                    res = em.SaveChanges();
                }
                catch(SqlException ex)
                {
                    String msg = "";
                    if (ex.Number == 1405)
                        msg = "Valor de clave primaria Repetido";
                    if (ex.Number == 23401)
                        msg = "Falta definir el valor de la Propiedad";
                    throw new Exception(msg);
                }
            }
            else
            {
                res = -1;
                throw new ArgumentException("Cliente ya existe, no es posible registrar.") ;
            }


            return res;


        }

        public override List<Cliente> GetEntities()
        {
            return em.Cliente.ToList<Cliente>();
        }

        public override int DeleteEntity(object key)
        {
            int res = 0;
            Cliente cliente = GetEntity(key);
            if (cliente != null)
            {
                em.Cliente.Remove(cliente);
                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede Eliminar Cliente , debido a que no existe o esta relacionado  ");

            }
            return res;
        }
  
        public override Cliente GetEntity(object key)
        {
           
            //Cliente cliente = (Cliente)key;
            //String rutCliente = cliente.RutCliente;

            return em.Cliente.Where(a => a.RutCliente == (string)key).FirstOrDefault<Cliente>();
            //return em.Cliente.Where(a => a.RutCliente == rutCliente).FirstOrDefault<Cliente>();
        }

        public override List<Cliente> GetEntity()
        {
          
            return em.Cliente.ToList<Cliente>();
        }

        public override int UpdateEntity(Cliente entity)
        {
            int res = 0;
            Cliente cliente = GetEntity(entity.RutCliente);
            if (cliente != null)
            {
                cliente.NombreContacto = entity.NombreContacto;
                cliente.IdActividadEmpresa = entity.IdActividadEmpresa;
                cliente.IdTipoEmpresa = entity.IdTipoEmpresa;
                cliente.MailContacto = entity.MailContacto;
                cliente.Telefono = entity.Telefono;
                res=em.SaveChanges();
            }
            else
            {
                res = -1;
                throw new ArgumentException("No se puede actualizar los Datos de Cliente,debido a que no existe ");
            }
            return res;
        }

    }
}