using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Model
{
   public interface IRoleDetailRepository : IBaseRepository<RoleDetail>
   {
      IList<RoleDetail> GetAllByRoleKode(string roleKode);
      IList<RoleDetail> GetByMenuParent(string roleKode, string menuParent);
      IList<string> GetAllMenuNameByTagAction(string roleKode, string formAction);
      int Save(List<RoleDetail> listObj);
      int DeleteAll();
   }

   public class RoleDetailRepository : IRoleDetailRepository
   {

      #region >> Fields <<

      private IDapperContext _context;
      private string _sqlTemplate = "SELECT * FROM role_detail {WHERE} {ORDER}";

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public RoleDetailRepository(IDapperContext context)
      {
         _context = context;
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<RoleDetail> GetAll()
      {
         throw new NotImplementedException();
      }

      public IList<RoleDetail> GetAllByRoleKode(string roleKode)
      {
         IList<RoleDetail> listObj = null;

         try
         {
            string sql = _sqlTemplate.Replace("{WHERE}", "WHERE role_kode = @kode")
               .Replace("{ORDER}", "");

            listObj = _context.Conn.Query<RoleDetail>(sql, new { kode = roleKode }).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return listObj;
      }

      public IList<RoleDetail> GetByMenuParent(string roleKode, string menuParent)
      {
         IList<RoleDetail> listObj = null;

         try
         {
            string sql = _sqlTemplate.Replace("{WHERE}", "WHERE role_kode = @kode "
               + "AND (menu_name = @menu OR menu_parent = @menu)").Replace("{ORDER}", "");

            listObj = _context.Conn.Query<RoleDetail>(sql, new { kode = roleKode, menu = menuParent }).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return listObj;
      }

      public IList<string> GetAllMenuNameByTagAction(string roleKode, string formAction)
      {
         IList<string> listObj = null;

         try
         {
            string sql2 = "SELECT menu_name FROM role_detail WHERE role_kode = @kode "
               + "AND form_action = @form AND tag = 'action'";

            listObj = _context.Conn.Query<string>(sql2, new { kode = roleKode, form = formAction }).ToList();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return listObj;
      }

      public int Save(RoleDetail obj)
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

      public int Save(List<RoleDetail> listObj)
      {
         var result = 0;

         try
         {
            _context.Conn.Insert(listObj);
            result = 1;
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
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

         try
         {
            string sql = "DELETE FROM role_detail WHERE (role_kode = @kode AND menu_name = @parent) "
               + "OR (role_kode = @kode AND menu_parent = @parent)";

            result = _context.Conn.Execute(sql, new
            {
               kode = obj.role_kode,
               parent = obj.menu_parent
            });
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return result;
      }

      public int DeleteAll()
      {
         var result = 0;

         try
         {
            result = _context.Conn.DeleteAll<RoleDetail>() ? 1 : 0;
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
