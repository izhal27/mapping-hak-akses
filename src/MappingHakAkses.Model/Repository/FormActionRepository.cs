using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Model
{
   public interface IFormActionRepository : IBaseRepository<FormAction>
   {
      IList<FormAction> GetAllByFormName(string formName);
      FormAction GetByFormName(string formName);
      int DeleteAll();
   }

   public class FormActionRepository : IFormActionRepository
   {

      #region >> Fields <<

      private IDapperContext _context;
      private string _sqlTemplate = "SELECT * FROM form_action {WHERE} {ORDER}";

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FormActionRepository(IDapperContext context)
      {
         _context = context;
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<FormAction> GetAll()
      {
         IList<FormAction> listObj = null;

         try
         {
            string sql = _sqlTemplate.Replace("{WHERE}", "")
               .Replace("{ORDER}", "form_name");

            listObj = _context.Conn.Query<FormAction>(sql).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return listObj;
      }

      public IList<FormAction> GetAllByFormName(string formName)
      {
         IList<FormAction> listObj = null;

         try
         {
            string sql = _sqlTemplate.Replace("{WHERE}", "WHERE form_name = @name")
               .Replace("{ORDER}", "");

            listObj = _context.Conn.Query<FormAction>(sql, new { name = formName }).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return listObj;
      }


      public FormAction GetByFormName(string formName)
      {
         FormAction obj = null;

         string sql = _sqlTemplate.Replace("{WHERE}", "WHERE form_name = @formName")
            .Replace("{ORDER}", "");

         obj = _context.Conn.Query<FormAction>(sql, new { formName = formName }).FirstOrDefault();

         return obj;
      }

      public int Save(FormAction obj)
      {
         var result = 0;

         try
         {
            _context.Conn.Insert(obj);
            result = 1;
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
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

         try
         {
            result = _context.Conn.DeleteAll<FormAction>() ? 1 : 0;
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return result;
      }

      #endregion

   }
}
