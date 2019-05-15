using MappingHakAkses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Controller
{
   public interface IFormActionController : IBaseController<FormAction>
   {
      IList<FormAction> GetAllByFormName(string formName);
      FormAction GetByFormName(string formName);
      int DeleteAll();
   }

   public class FormActionController : IFormActionController
   {

      #region >> Fields <<

      private IFormActionRepository _repository;

      #endregion
      
      // ----------------------------------------------------------------------//

      #region Methods

      public IList<FormAction> GetAll()
      {
         IList<FormAction> listObj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new FormActionRepository(context);
            listObj = _repository.GetAll();
         }

         return listObj;
      }

      public IList<FormAction> GetAllByFormName(string formName)
      {
         IList<FormAction> listObj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new FormActionRepository(context);
            listObj = _repository.GetAllByFormName(formName);
         }

         return listObj;
      }

      public FormAction GetByFormName(string formName)
      {
         FormAction obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new FormActionRepository(context);
            obj = _repository.GetByFormName(formName);
         }

         return obj;
      }

      public int Save(FormAction obj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new FormActionRepository(context);
            result = _repository.Save(obj);
         }

         return result;
      }

      public int Update(FormAction obj)
      {
         throw new NotImplementedException();
      }

      public int Delete(FormAction obj)
      {
         throw new NotImplementedException();
      }

      public int DeleteAll()
      {
         var result = 0;
         
         using (IDapperContext context = new DapperContext())
         {
            _repository = new FormActionRepository(context);
            result = _repository.DeleteAll();
         }

         return result;
      }

      #endregion

   }
}
