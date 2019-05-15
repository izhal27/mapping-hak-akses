using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Model
{
   public interface IOperatorRepository : IBaseRepository<Operator>
   {
      Operator GetByID(object id);
      Operator GetByLoginID(string loginID);
   }

   public class OperatorRepository : IOperatorRepository
   {

      #region >> Fields <<

      private IDapperContext _context;
      private string _sqlTemplate = "SELECT * FROM operator {WHERE} {ORDER}";

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public OperatorRepository(IDapperContext context)
      {
         _context = context;
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<Operator> GetAll()
      {
         IList<Operator> listObj = null;

         try
         {
            string sql = "SELECT o.*, r.nama AS role_nama FROM operator o "
               + "LEFT JOIN role r ON o.role_kode = r.kode ORDER BY o.nama ASC";

            listObj = _context.Conn.Query<Operator>(sql).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return listObj;
      }

      public Operator GetByID(object id)
      {
         Operator obj = null;

         try
         {
            string sql = _sqlTemplate.Replace("{WHERE}", "WHERE id = @id")
               .Replace("{ORDER}", "");

            obj = _context.Conn.Query<Operator>(sql, new { id = id }).FirstOrDefault();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return obj;
      }

      public Operator GetByLoginID(string loginID)
      {
         Operator obj = null;

         try
         {
            string sql = _sqlTemplate.Replace("{WHERE}", "WHERE login_id = @login_id")
               .Replace("{ORDER}", "");

            obj = _context.Conn.Query<Operator>(sql, new { login_id = loginID }).FirstOrDefault();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return obj;
      }

      public int Save(Operator obj)
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

      public int Update(Operator obj)
      {
         var result = 0;

         try
         {
            result = _context.Conn.Update(obj) ? 1 : 0;
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return result;
      }

      public int Delete(Operator obj)
      {
         var result = 0;

         try
         {
            result = _context.Conn.Delete(obj) ? 1 : 0;
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
