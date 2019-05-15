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
   public partial class FrmEntryOperator : FrmBaseEntry
   {

      #region >> Fields <<

      private readonly IOperatorController _controller;
      private Operator _operatorObj;

      #endregion

      // ----------------------------------------------------------------------//

      public FrmEntryOperator()
      {
         InitializeComponent();
      }

      public FrmEntryOperator(bool isEdited, int id = 0) : this()
      {
         _controller = new OperatorController();

         EntityName = FrmOperator.EntityName;
         SetControls(isEdited, id);

         if (!isEdited) _operatorObj = new Operator(); // Data baru
      }

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void FrmEntryOperator_Load(object sender, EventArgs e)
      {
         base.FrmBaseEntry_Load(sender, e);
      }

      private void Save_Click(object sender, EventArgs e)
      {
         using (new WaitCursorHandler())
         {
            if (MessagesHelper.ConfirmSave(EntityName))
            {
               var valResult = new ValidationError();
               SetPropertyValue();

               var result = _controller.Save(_operatorObj, ref valResult);

               if (result > 0) // Data berhasil ditambah
               {
                  SaveResult(activeControl: txtNama);
                  cmbRole.SelectedIndex = 0;
               }
               else
               {
                  ErrorResult(valResult);
               }
            }
         }
      }

      private void Update_Click(object sender, EventArgs e)
      {
         using (new WaitCursorHandler())
         {
            if (MessagesHelper.ConfirmUpdate(EntityName))
            {
               var valResult = new ValidationError();
               SetPropertyValue();

               var result = _controller.Update(_operatorObj, ref valResult);

               if (result > 0) // Data berhasil disimpan
               {
                  UpdateResult();
               }
               else
               {
                  ErrorResult(valResult);
               }
            }
         }
      }

      private void chkBoxShowCharacters_CheckedChanged(object sender, EventArgs e)
      {
         // Tampilkan karakter password ketika CheckBox tampilkan dicentang,
         // sebaliknya sembunyikan password dengan password char
         var status = ((CheckBox)sender).Checked;

         txtPassword.UseSystemPasswordChar = !status;
         txtKonfPassword.UseSystemPasswordChar = !status;
      }

      private void txtBox_ImeModeChanged(object sender, EventArgs e)
      {
         ((TextBox)sender).PasswordChar = '\0'; // Disable password char
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      /// <summary>
      /// Atur tampilan Controls
      /// </summary>
      /// <param name="isEdited">Staus operasi, True data baru, sebaliknya false</param>
      /// <param name="id">ID object yang ingin diubah</param>
      private void SetControls(bool isEdited = false, int id = 0)
      {
         using (new WaitCursorHandler())
         {
            var listObj = new RoleController().GetAll();
            var kvpDataSource = listObj.Select(t => new KeyValuePair<object, string>(t.kode, t.nama)).ToList();
            // Atur data source ComboBox Tipe menu
            cmbRole.SetDataSource(kvpDataSource, false);

            if (isEdited)
            {
               ControlStatus($"Ubah {EntityName}", "&Simpan", Update_Click);
            }
            else
            {
               ControlStatus($"Tambah {EntityName}", "&Tambah", Save_Click);
            }
            
            PopulateControls(id);
         }
      }

      /// <summary>
      /// Isi data Controls sesuai dengan data object yang ingin diubah
      /// </summary>
      /// <param name="id">ID Object</param>
      private void PopulateControls(int id)
      {
         _operatorObj = _controller.GetByID(id);

         if (_operatorObj != null)
         {
            txtNama.Text = _operatorObj.nama;
            txtAlamat.Text = _operatorObj.alamat;
            txtHp.Text = _operatorObj.hp;
            txtLoginID.Text = _operatorObj.login_id;
            cmbRole.SelectedValue = _operatorObj.role_kode;
         }
      }

      /// <summary>
      /// Atur property value object
      /// </summary>
      private void SetPropertyValue()
      {
         _operatorObj.SetPropertyValue(txtNama.Text, txtAlamat.Text
            , txtHp.Text, txtLoginID.Text, txtPassword.Text
            , txtKonfPassword.Text, cmbRole.SelectedValue.ToString());
      }

      #endregion

   }
}
