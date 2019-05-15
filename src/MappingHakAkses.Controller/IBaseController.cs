using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Controller
{
   public interface IBaseController<T> where T : class
   {
      IList<T> GetAll();
      int Save(T obj);
      int Update(T obj);
      int Delete(T obj);
   }
}
