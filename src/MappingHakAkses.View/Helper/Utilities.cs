using MappingHakAkses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingHakAkses.View
{
   public static class Utilities
   {

      /// <summary>
      /// Method yang digunakan untuk menampilkan error validasi
      /// </summary>
      /// <param name="form">Form target</param>
      /// <param name="validationError">ValidationError object</param>
      public static void ErrorResult(Control form, ValidationError validationError)
      {
         // Jika terdapat error pada saat validasi maka,
         // jika PropertyName mengandung control pada form, focus diarahkan ke control tersebut.
         // Contoh : jika user belum memasukan nama di dalam TextBox nama maka,
         // berikan peringatan kepada user dan focus diarahkan ke TextBox nama
         if (validationError.Message != null && validationError.Message.Length > 0)
         {
            MessagesHelper.Warning(validationError.Message); // Pesan kepada user
            var ctrl = form.FindControl(validationError.PropertyName);
            if (ctrl != null) ctrl.Focus();
         }
         else
         {
            MessagesHelper.DefaultGenericError(); // Pesan kesalahan umum
         }
      }

   }
}
