using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Model
{
   public interface IRoleRepository : IBaseRepository<Role>
   {
      Role GetByID(object id);
      Role GetByKode(string kode);
      Role GetByNama(string nama);
   }

   public class RoleRepository : IRoleRepository
   {

      #region >> Fields <<

      private IDapperContext _context;
      private string _sqlTemplate = "SELECT * FROM role {WHERE} {ORDER}";

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public RoleRepository(IDapperContext context)
      {
         _context = context;
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<Role> GetAll()
      {
         IList<Role> listObj = null;

         try
         {
            string sql = _sqlTemplate.Replace("{WHERE}", "")
               .Replace("{ORDER}", "ORDER BY kode ASC");

            listObj = _context.Conn.Query<Role>(sql).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return listObj;
      }

      public Role GetByID(object id)
      {
         Role obj = null;

         string sql = _sqlTemplate.Replace("{WHERE}", "WHERE id = @id")
            .Replace("{ORDER}", "");

         obj = _context.Conn.Query<Role>(sql, new { id = id }).FirstOrDefault();

         return obj;
      }

      public Role GetByKode(string kode)
      {
         Role obj = null;

         string sql = _sqlTemplate.Replace("{WHERE}", "WHERE kode = @kode")
            .Replace("{ORDER}", "");

         obj = _context.Conn.Query<Role>(sql, new { kode = kode }).FirstOrDefault();

         return obj;
      }

      public Role GetByNama(string nama)
      {
         Role obj = null;

         string sql = _sqlTemplate.Replace("{WHERE}", "WHERE nama = @nama")
            .Replace("{ORDER}", "");

         obj = _context.Conn.Query<Role>(sql, new { nama = nama }).FirstOrDefault();

         return obj;
      }

      public int Save(Role obj)
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

      public int Update(Role obj)
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

      public int Delete(Role obj)
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
