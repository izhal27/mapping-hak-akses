using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingHakAkses.View
{
   public partial class FrmSubMenu2 : Form
   {
      
      #region >> Constructor <<

      public FrmSubMenu2()
      {
         InitializeComponent();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void FrmSubMenu2_Load(object sender, EventArgs e)
      {
         var roleManager = new RoleManager();
         // Enable buttons
         roleManager.EnableButtons(this);
      }

      #endregion

   }
}
