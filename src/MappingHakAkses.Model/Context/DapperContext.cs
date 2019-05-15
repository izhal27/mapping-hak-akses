using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Model
{
   public interface IDapperContext : IDisposable
   {
      IDbConnection Conn { get; }
      IDbTransaction Transaction { get; }
      Guid Guid { get; }
      bool TestKoneksi();
      void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
      void Commit();
      void Rollback();
   }

   public class DapperContext : IDapperContext
   {

      #region >> Fields <<

      private IDbConnection _conn = null;
      private IDbTransaction _transaction = null;
      private readonly string _providerName;
      private readonly string _connString;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Properties <<

      /// <summary>
      /// Instance Connection state open
      /// </summary>
      public IDbConnection Conn
      {
         get
         {
            // Jika connection belum dibuat maka, buat koneksi yang baru
            // sebaliknya ambil koneksi yang sekarang jika sudah ada
            return _conn ?? (_conn = GetOpenConnection(_providerName, _connString));
         }
      }

      /// <summary>
      /// Instance Transaction
      /// </summary>
      public IDbTransaction Transaction
      {
         get
         {
            return _transaction;
         }
      }

      /// <summary>
      /// Get new Guid
      /// </summary>
      public Guid Guid
      {
         get
         {
            return Guid.NewGuid();
         }
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public DapperContext()
      {
         var server = ConfigurationManager.AppSettings["Server"] ?? "";
         var db = ConfigurationManager.AppSettings["DB"] ?? "";
         var user = ConfigurationManager.AppSettings["User"] ?? "";
         var password = ConfigurationManager.AppSettings["Password"] ?? "";

         _providerName = "MySql.Data.MySqlClient";
         _connString = $@"server={server};database={db}; "
            + $@"username={user};password={password}";

         // Jika koneski null maka, buat koneksi baru
         // sebaliknya gunakan koneksi sekarang
         if (_conn == null)
         {
            _conn = GetOpenConnection(_providerName, _connString);
         }
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      /// <summary>
      /// Membuat koneski baru dengan state open
      /// </summary>
      /// <param name="providerName">Provider name DBMS</param>
      /// <param name="connString">Connection string</param>
      /// <returns>Koneksi dengan state open</returns>
      private IDbConnection GetOpenConnection(string providerName, string connString)
      {
         IDbConnection conn = null;

         try
         {
            DbProviderFactory provider = DbProviderFactories.GetFactory(providerName);
            conn = provider.CreateConnection(); // Buat koneksi sesuai provider name DBMS
            conn.ConnectionString = connString;
            conn.Open();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }

         return conn;
      }

      /// <summary>
      /// Pengecekan koneksi ke database
      /// </summary>
      /// <returns>Mengembalikan true jika berhasil, sebaliknya false
      /// jika database tidak aktif / tidak ditemukan</returns>
      public bool TestKoneksi()
      {
         var isConnected = false;

         try
         {
            using (var conn = GetOpenConnection(_providerName, _connString))
            {
               isConnected = conn.State == ConnectionState.Open;
            }
         }
         catch
         {
         }

         return isConnected;
      }

      /// <summary>
      /// Method yang digunakan untuk memulai transaction DBMS
      /// </summary>
      /// <param name="isolationLevel"></param>
      public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
      {
         if (_transaction == null) _transaction = Conn.BeginTransaction(isolationLevel);
      }

      /// <summary>
      /// Method yang digunakkan untuk menyimpan data ketika sukses
      /// </summary>
      public void Commit()
      {
         if (_transaction != null)
         {
            _transaction.Commit();
            _transaction = null;
         }
      }

      /// <summary>
      /// Method yang digunakan untuk mengembalikan data ketika gagal
      /// </summary>
      public void Rollback()
      {
         if (_transaction != null)
         {
            _transaction.Rollback();
            _transaction = null;
         }
      }
      
      public void Dispose()
      {
         if (_conn != null)
         {
            try
            {
               // Jika pada saat object akan dihapus dari memory koneksi masih open
               // maka rollback / batalkan operasi sekrang, kemudian tutup koneksi
               if (_conn.State != ConnectionState.Closed)
               {
                  Rollback();
                  _conn.Close();
               }
            }
            finally
            {
               _conn.Dispose();
            }
         }

         GC.SuppressFinalize(this);
      }

      #endregion

   }
}
