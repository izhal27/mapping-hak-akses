using MappingHakAkses.Model;
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
   public partial class FrmBaseEntry : Form
   {

      #region >> Properties <<

      public IListener Listener { private get; set; }
      protected string EntityName { get; set; }

      #endregion
      

      public FrmBaseEntry()
      {
         InitializeComponent();
      }

      protected virtual void FrmBaseEntry_Load(object sender, EventArgs e)
      {
         ActiveControl = btnCancel;
      }

      protected virtual void FrmBaseOperasi_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Escape) Close();
      }

      protected virtual void btnCancel_Click(object sender, EventArgs e)
      {
         Close();
      }

      /// <summary>
      /// Status control pada saat menambahkan/mengubah data
      /// </summary>
      /// <param name="formText">Form text</param>
      /// <param name="btnOperasiText">Button operasi text</param>
      /// <param name="eventHandler">Button operasi event handler</param>
      protected void ControlStatus(string formText, string btnOperasiText, EventHandler eventHandler)
      {
         Text = formText;
         btnOperasi.Text = btnOperasiText;
         btnOperasi.Click += eventHandler;
      }

      /// <summary>
      /// Method yang dijalankan ketika sukses menambahkan data
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="data"></param>
      /// <param name="activeControl">Set active controls</param>
      /// <param name="paramAction">Method yang ingin</param>
      protected void SaveResult(object sender = null, object data = null
         , Control activeControl = null)
      {
         MessagesHelper.InfoSave(EntityName);
         Listener.Ok(sender, data);
         Controls.ClearControls();
         if (activeControl != null) ActiveControl = activeControl;
      }

      /// <summary>
      /// Method yang dijalankan ketika sukses menyimpan data
      /// </summary>
      protected void UpdateResult()
      {
         MessagesHelper.InfoUpdate(EntityName);
         DialogResult = DialogResult.OK;
      }

      /// <summary>
      /// Menampilkan pesan error
      /// </summary>
      /// <param name="validationError">Validation error</param>
      protected void ErrorResult(ValidationError validationError)
      {
         Utilities.ErrorResult(this, validationError);
      }

   }
}
