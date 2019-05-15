/*****************************************************************************************
**                                                                                      **
**                                     iCoffeeShop                                      **
**                                Risal Walangadi © 2018                                **
**                                                                                      **
**--------------------------------------------------------------------------------------**
**                                                                                      **
**  File Name : IBaseRepository.cs                                                      **
**  Description : Interface Base Repository operasi umum untuk CRUD database            **
**  License : Apache Version 2.0                                                        **
**  http://www.apache.org/licenses/LICENSE-2.0                                          **
**                                                                                      **
*****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Model
{
   public interface IBaseRepository<T> where T : class
   {
      IList<T> GetAll();
      int Save(T obj);
      int Update(T obj);
      int Delete(T obj);
   }
}
