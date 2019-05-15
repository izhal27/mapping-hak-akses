using MappingHakAkses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Controller
{
   public interface IBaseValidatorController<T>
   {
      int Save(T obj, ref ValidationError validationError);
      int Update(T obj, ref ValidationError validationError);
   }
}
