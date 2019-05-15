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
   public partial class FrmEntryHakAkses : FrmBaseEntry
   {

      #region >> Fields <<

      private readonly IRoleController _controller;
      private Role _roleObj;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmEntryHakAkses()
      {
         InitializeComponent();
      }

      public FrmEntryHakAkses(bool isEdited, int id = 0) : this()
      {
         EntityName = FrmHakAkses.EntityName;
         _controller = new RoleController();

         SetControls(isEdited, id);

         if (!isEdited) _roleObj = new Role(); // Data baru
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      protected override void FrmBaseEntry_Load(object sender, EventArgs e)
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

               var result = _controller.Save(_roleObj, ref valResult);

               if (result > 0) // Data berhasil ditambahkan
               {
                  SaveResult(activeControl: txtKode);
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

               var result = _controller.Update(_roleObj, ref valResult);

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
         _roleObj = _controller.GetByID(id);

         if (_roleObj != null)
         {
            txtKode.Text = _roleObj.kode;
            txtNama.Text = _roleObj.nama;
            txtKeterangan.Text = _roleObj.keterangan ?? "";
         }
      }

      /// <summary>
      /// Atur property value object
      /// </summary>
      private void SetPropertyValue()
      {
         _roleObj.SetPropertyValue(txtKode.Text, txtNama.Text
            , txtKeterangan.Text, MainProgram.OperatorActive.id);
      }

      #endregion

   }
}
