using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Controller
{
   public abstract class ErrorMessage
   {
      public static string EmptyInput = "Maaf, Anda belum memasukkan '{PropertyName}' !!!";
      public static string MaxLength = "Maaf, Panjang '{PropertyName}' maksimal {MaxLength} karakter !!!";
      public static string MaxMinLength = "Maaf, Panjang '{PropertyName}' minimal {MinLength} karakter, "
         + "maksimal {MaxLength} karakter !!!";
      public static string NotEmpty = "Maaf, '{PropertyName}' harus diisi !!!";
      public static string NotSelected = "Maaf, anda belum memilih '{PropertyName}' !!!";
      public static string NotUnique = "Maaf, '{PropertyName}' sudah digunakan.\n"
         + "Silahkan coba dengan '{PropertyName}' yang lain !!!";
      public static string WrongInput = "Maaf, '{PropertyName}' yang anda masukan salah !!!";
   }
}
