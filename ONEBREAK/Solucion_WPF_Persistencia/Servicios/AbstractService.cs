using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;

namespace Servicios
{
    public abstract class AbstractService<T>
    {
        //planilla de metodos para conexión BD
        //CRUD 

            

        protected OnBreakEntities em = new OnBreakEntities();


        public abstract int AddEntity(T entity);

        public abstract int UpdateEntity(T entity);
    
        public abstract int DeleteEntity( object key);

        public abstract T GetEntity(object key);

        public abstract List<T> GetEntity();

        public abstract List<T> GetEntities();
    }
}
