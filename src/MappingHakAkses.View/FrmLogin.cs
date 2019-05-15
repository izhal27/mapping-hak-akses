using MappingHakAkses.Controller;
using MappingHakAkses.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MappingHakAkses.View
{
   public partial class FrmLogin : Form
   {

      #region >> Fields <<

      private readonly IOperatorController _controller;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Properties <<

      /// <summary>
      /// Login ID yang dimasukkan
      /// </summary>
      public string LoginID
      {
         get
         {
            return txtLoginID.Text;
         }
      }

      /// <summary>
      /// Password yang dimasukkan
      /// </summary>
      public string Password
      {
         get
         {
            return txtPassword.Text;
         }
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmLogin()
      {
         InitializeComponent();

         _controller = new OperatorController();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void FrmLogin_Load(object sender, EventArgs e)
      {
         ActiveControl = txtLoginID;
      }

      private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
      {
         switch (e.KeyCode)
         {
            case Keys.Enter:

               btnLogin_Click(null, null);

               break;
            case Keys.Escape:

               btnCancel_Click(null, null);

               break;
         }
      }

      private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
      {
         btnCancel_Click(null, null);
      }

      private void chkBoxShowCharacters_CheckedChanged(object sender, EventArgs e)
      {
         // Tampilkan karakter di TextBox password jika CheckBox tampilkan dicentang,
         // sebaliknya sembunyikan karakter dengan password char
         var status = ((CheckBox)sender).Checked;

         txtPassword.UseSystemPasswordChar = !status;
      }

      private void txtPassword_ImeModeChanged(object sender, EventArgs e)
      {
         ((TextBox)sender).PasswordChar = '\0'; // Disable password char
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         try
         {
            var obj = new Operator()
            {
               login_id = LoginID,
               password = Password
            };

            var validationError = new ValidationError();

            if (_controller.Login(obj, ref validationError)) // Login berhasil
            {
               // Atur property OperatorActive pada MainProgram
               MainProgram.OperatorActive = _controller.GetByLoginID(LoginID);

               Hide(); // Sembunyikan Form login

               var frmMain = new FrmMain();
               frmMain.ShowDialog(); // Tampilkan From main
            }
            else // Gagal melakukan login
            {
               Utilities.ErrorResult(this, validationError);

               if (string.IsNullOrWhiteSpace(validationError.PropertyName))
               {
                  txtLoginID.Clear();
                  txtPassword.Clear();
               }

               txtLoginID.Focus();
            }
         }
         catch (Exception ex)
         {
            MessagesHelper.DefaultGenericError(ex.Message);
            Application.Exit();
         }
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      #endregion
   }
}
