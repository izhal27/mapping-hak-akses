using MappingHakAkses.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingHakAkses.View
{
   static class MainProgram
   {

      /// <summary>
      /// Object operator saat ini
      /// </summary>
      public static Operator OperatorActive
      {
         get;
         set;
      }

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         // Pengecekan jika aplikasi tidak sedang berjalan
         if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count() > 1)
         {
            MessagesHelper.Error("Aplikasi Sedang Berjalan.");
            return;
         }

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new FrmLogin());
      }
   }
}
