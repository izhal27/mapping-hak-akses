using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingHakAkses.View
{
   public partial class FrmMain : Form
   {

      #region >> Constructor <<

      public FrmMain()
      {
         InitializeComponent();

         // Inisialisai data class RoleManager
         RoleManager.MenuStrip = menuStripMain;
         RoleManager.ToolStrip = toolStripMain;
         RoleManager.RoleKode = MainProgram.OperatorActive.role_kode;

         var roleManager = new RoleManager();

         // DEVELOPER MODE
         //
         // AKtifkan pemangilan method dibawah ini untuk mereset data pada tabel form_action dan role_detail ketika anda menambahkan Menu, Form, atau control baru,
         // jangan lupa nonaktifkan kembali, agar tidak melakukan reset setiap kali aplikasi dijalankan.
         //
         // roleManager.ResetFormAction(Assembly.GetExecutingAssembly());

         // Enable/Disable MenuStrip dan ToolStrip sesuai Role operator
         roleManager.PopulateRoleDetailToMenuStripAndToolStrip();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
      {
         Logout();
      }

      private void tsMenuHakAkses_Click(object sender, EventArgs e)
      {
         new FrmHakAkses().ShowDialog();
      }

      private void tsMenuOperator_Click(object sender, EventArgs e)
      {
         new FrmOperator().ShowDialog();
      }

      private void tsMenuSubMenu1_1_Click(object sender, EventArgs e)
      {
         new FrmSubMenu1().ShowDialog();
      }

      private void tsMenuSubMenu2_1_Click(object sender, EventArgs e)
      {
         new FrmSubMenu2().ShowDialog();
      }

      private void tsMenuSubMenu3_1_Click(object sender, EventArgs e)
      {
         new FrmSubMenu3().ShowDialog();
      }

      private void tsMenuSubMenu4_1_Click(object sender, EventArgs e)
      {
         new FrmSubMenu4().ShowDialog();
      }

      private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (MessagesHelper.Confirm("Lanjutkan proses logout?"))
         {
            Logout();
         }
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      /// <summary>
      /// Method yang dilakukan untuk Logout dari aplikasi
      /// </summary>
      private void Logout()
      {
         MainProgram.OperatorActive = null;
         Dispose();
         new FrmLogin().ShowDialog();
      }

      #endregion

   }
}
