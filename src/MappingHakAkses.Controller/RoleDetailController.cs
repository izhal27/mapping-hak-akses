using MappingHakAkses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Controller
{
   public interface IRoleDetailController : IBaseController<RoleDetail>
   {
      IList<RoleDetail> GetAllByRoleKode(string roleKode);
      IList<RoleDetail> GetByMenuParent(string roleKode, string menuParent);
      IList<string> GetAllMenuNameByTagAction(string roleKode, string formAction);
      int Save(List<RoleDetail> listObj);
      int DeleteAll();
   }

   public class RoleDetailController : IRoleDetailController
   {

      #region >> Fields <<

      private IRoleDetailRepository _repository;

      #endregion

      // ----------------------------------------------------------------------//

      #region Methods

      public IList<RoleDetail> GetAll()
      {
         throw new NotImplementedException();
      }

      public IList<RoleDetail> GetAllByRoleKode(string roleKode)
      {
         IList<RoleDetail> listObj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleDetailRepository(context);
            listObj = _repository.GetAllByRoleKode(roleKode);
         }

         return listObj;
      }

      public IList<RoleDetail> GetByMenuParent(string roleKode, string menuParent)
      {
         IList<RoleDetail> listObj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleDetailRepository(context);
            listObj = _repository.GetByMenuParent(roleKode, menuParent);
         }

         return listObj;
      }

      public IList<string> GetAllMenuNameByTagAction(string roleKode, string formAction)
      {
         IList<string> listObj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleDetailRepository(context);
            listObj = _repository.GetAllMenuNameByTagAction(roleKode, formAction);
         }

         return listObj;
      }

      public int Save(RoleDetail obj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleDetailRepository(context);
            result = _repository.Save(obj);
         }

         return result;
      }

      public int Save(List<RoleDetail> listObj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleDetailRepository(context);
            result = _repository.Save(listObj);
         }

         return result;
      }

      public int Update(RoleDetail obj)
      {
         throw new NotImplementedException();
      }

      public int Delete(RoleDetail obj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleDetailRepository(context);
            result = _repository.Delete(obj);
         }

         return result;
      }

      public int DeleteAll()
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleDetailRepository(context);
            result = _repository.DeleteAll();
         }

         return result;
      }

      #endregion

   }
}
