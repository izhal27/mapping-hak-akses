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
   public partial class FrmHakAkses : Form, IListener
   {

      #region >> Fields <<

      private readonly IRoleController _controller;
      private RoleManager _roleManager;
      private BindingListView<Role> _view;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Properties <<

      /// <summary>
      /// Row / object terpilih di DataGridView
      /// </summary>
      private Role DgvRoleSelectedItem
      {
         get
         {
            if (dgvRole.DataSource != null && dgvRole.CurrentRow != null)
            {
               return ((ObjectView<Role>)dgvRole.CurrentRow.DataBoundItem).Object;
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
            if (DgvRoleSelectedItem == null)
            {
               MessagesHelper.NotSelected(EntityName);
               return false;
            }

            return true;
         }
      }

      public static string EntityName
      {
         get
         {
            return nameof(Role);
         }
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmHakAkses()
      {
         InitializeComponent();

         _controller = new RoleController();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void FrmHakAkses_Load(object sender, EventArgs e)
      {
         try
         {
            using (new WaitCursorHandler())
            {
               // Catatan: Jangan tempatkan create instance Role manager ini pada contsructor
               // form (kecuali form yang dilewati, seperti form main / base),
               // agar tdk terjadi infinite loop pada saat GetAssemblyType
               // di method reset Form action dan Role detail pada class Role manager
               _roleManager = new RoleManager();
               _roleManager.TreeView = treeViewAction;
               // Enable buttons
               _roleManager.EnableButtons(this);

               var listObj = _controller.GetAll().ToList();
               _view = new BindingListView<Role>(listObj);

               dgvRole.DataSource = _view;

               // Atur DataSource ComboBox menu
               var listKvp = _roleManager.DataSourceMenuParent();
               cmbMenu.SetDataSource(listKvp, false);

               PopulateMenuStripToTreeView();

               dgvRole.CellDoubleClick += DgvRole_CellDoubleClick;
               dgvRole.SelectionChanged += DgvRole_SelectionChanged;
               cmbMenu.SelectedIndexChanged += CmbMenu_SelectedIndexChanged;
            }
         }
         catch (Exception ex)
         {
            MessagesHelper.Error(ex);
         }
      }

      private void DgvRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (btnUbah.Enabled)
            btnUbah_Click(null, null);
      }

      private void DgvRole_SelectionChanged(object sender, EventArgs e)
      {
         chkbPilihSemua.Checked = false;
         PopulateRoleToTreeView();
      }
      
      private void CmbMenu_SelectedIndexChanged(object sender, EventArgs e)
      {
         PopulateMenuStripToTreeView();
      }

      private void chkbPilihSemua_CheckedChanged(object sender, EventArgs e)
      {
         CheckedTreeViewNode(((CheckBox)sender).Checked, treeViewAction.Nodes);
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         if (ObjectIsSelected)
         {
            if (MessagesHelper.Confirm($"Update action {EntityName} terpilih?"))
            {
               var itemSelected = DgvRoleSelectedItem;

               var result = _roleManager.UpdateRole(itemSelected.kode, cmbMenu.SelectedValue.ToString());

               if (result > 0) // Data berhasil diupdate
               {
                  MessagesHelper.Info("Role berhasil diupdate");
               }
               else
               {
                  MessagesHelper.DefaultGenericError();
               }
            }
         }
      }

      private void btnTambah_Click(object sender, EventArgs e)
      {
         using (new WaitCursorHandler())
         {
            var frm = new FrmEntryHakAkses(false);
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
               var obj = DgvRoleSelectedItem;
               var frm = new FrmEntryHakAkses(true, obj.id);

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
               var obj = DgvRoleSelectedItem;

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

      /// <summary>
      /// Isi TreeView dengan data dari MenuStrip
      /// </summary>
      private void PopulateMenuStripToTreeView()
      {
         _roleManager.PopulateMenuStripToTreeView(cmbMenu.SelectedValue.ToString());
         // Terapkan role terpilih ke TreeView
         PopulateRoleToTreeView();
      }

      /// <summary>
      /// Terapkan data dari role_detail ke TreeView sesuai dengan Role kode terpilih pada DataGridView
      /// </summary>
      private void PopulateRoleToTreeView()
      {
         if (DgvRoleSelectedItem != null)
         {
            var itemSelected = DgvRoleSelectedItem;
            _roleManager.PopulateRoleDetailToTreeView(itemSelected.kode, cmbMenu.SelectedValue.ToString());
         }
      }

      /// <summary>
      /// Check/Uncheck node di TreeView
      /// </summary>
      /// <param name="status">True/false</param>
      /// <param name="nodes">TreeView node</param>
      private void CheckedTreeViewNode(bool status, TreeNodeCollection nodes)
      {
         foreach (TreeNode node in nodes)
         {
            node.Checked = status;
            CheckedTreeViewNode(status, node.Nodes);
         }
      }

      public void Ok(object sender, object data)
      {
         RefreshDataSource();
      }

      #endregion

   }
}
