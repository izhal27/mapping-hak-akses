using Equin.ApplicationFramework;
using MappingHakAkses.Controller;
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
   public partial class FrmOperator : Form, IListener
   {

      #region >> Fields <<

      private readonly IOperatorController _controller;
      private BindingListView<Operator> _view;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Properties <<

      /// <summary>
      /// Row / object terpilih di DataGridView
      /// </summary>
      private object DgvDataSelectedItem
      {
         get
         {
            if (dgvOperator.DataSource != null && dgvOperator.CurrentRow != null)
            {
               return ((ObjectView<Operator>)dgvOperator.CurrentRow.DataBoundItem).Object;
            }

            return null;
         }
      }

      /// <summary>
      /// Pengecekan jika user sudah memilih data untuk di ubah / hapus,
      /// sebaliknya tampilkan peringatan jika belum ada data yg terpilih
      /// </summary>
      /// <returns>Mengembalikan true jika sudah ada data terpilih</returns>
      protected bool ObjectIsSelected
      {
         get
         {
            if (DgvDataSelectedItem == null)
            {
               MessagesHelper.NotSelected(EntityName);
               return false;
            }

            return true;
         }
      }

      public static string EntityName
      {
         get { return nameof(Operator); }
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmOperator()
      {
         InitializeComponent();

         _controller = new OperatorController();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void FrmOperator_Load(object sender, EventArgs e)
      {
         try
         {
            using (new WaitCursorHandler())
            {
               var roleManager = new RoleManager();
               // Enable buttons
               roleManager.EnableButtons(this);

               var listObj = _controller.GetAll().ToList();
               _view = new BindingListView<Operator>(listObj);

               dgvOperator.DataSource = _view;
            }
         }
         catch (Exception ex)
         {
            MessagesHelper.Error(ex);
         }
      }

      private void DgvOperator_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (btnUbah.Enabled)
            btnUbah_Click(null, null);
      }

      private void btnTambah_Click(object sender, EventArgs e)
      {
         using (new WaitCursorHandler())
         {
            var frm = new FrmEntryOperator(false);
            frm.Owner = this;
            frm.Listener = this;
            frm.ShowDialog();
         }
      }

      private void btnUbah_Click(object sender, EventArgs e)
      {
         using (new WaitCursorHandler())
         {
            if (ObjectIsSelected)
            {
               var obj = (Operator)DgvDataSelectedItem;
               var frm = new FrmEntryOperator(true, obj.id);

               if (frm.ShowDialog() == DialogResult.OK) RefreshDataSource(); // Data berhasil diubah
            }
         }
      }

      private void btnHapus_Click(object sender, EventArgs e)
      {
         using (new WaitCursorHandler())
         {
            if (ObjectIsSelected)
            {
               var obj = ((Operator)DgvDataSelectedItem);

               if (MessagesHelper.ConfirmDelete(EntityName))
               {
                  var result = _controller.Delete(obj);

                  if (result > 0) // Data berhasil dihapus
                  {
                     MessagesHelper.InfoDelete(EntityName);
                     RefreshDataSource();
                  }
                  else
                  {
                     MessagesHelper.ErrorHapus(EntityName);
                  }
               }
            }
         }
      }

      private void btnTutup_Click(object sender, EventArgs e)
      {
         Close();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<
         
      /// <summary>
      /// Atur ulang data source
      /// </summary>
      private void RefreshDataSource()
      {
         using (new WaitCursorHandler())
         {
            var listObj = _controller.GetAll().ToList();
            _view.DataSource = listObj;
         }
      }

      public void Ok(object sender, object data)
      {
         RefreshDataSource();
      }

      #endregion

   }
}
