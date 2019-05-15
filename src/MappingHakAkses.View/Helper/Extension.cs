using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingHakAkses.View
{
   public static class Extension
   {

      /// <summary>
      /// Method yang digunakan untuk mengatur data source ComboBox dari object List KeyValuePair,
      /// dengan menggunakan class BindingSource
      /// </summary>
      /// <param name="comboBox">ComboBox target</param>
      /// <param name="kvpDataSource">KeyValuePair data source</param>
      /// <param name="clearSelected">True jika ingin mengatur selected index ComboBox -1 </param>
      public static void SetDataSource(this ComboBox comboBox
         , List<KeyValuePair<object, string>> kvpDataSource, bool clearSelected = true)
      {
         // Atur data source ComboBox menggunakan class BindingSource
         comboBox.DataSource = new BindingSource(kvpDataSource, null);
         comboBox.ValueMember = "Key"; // Value member / id item
         comboBox.DisplayMember = "Value"; // Display member / text item yang ditampilkan di ComboBox
         if (clearSelected) comboBox.SelectedIndex = -1; // Jangan tampilkan item
      }

      /// <summary>
      /// Mencari control yang harus diisi melalui pengecekan tag control
      /// </summary>
      /// <param name="control">Control target</param>
      /// <param name="nama">Nama control target</param>
      /// <returns>Mengembalikan control jika ditemukan, sebaliknya null</returns>
      public static Control FindControl(this Control control, string nama)
      {
         // Cek jika tag control tidak null dan nama
         // sesuai dengan nama yang ingin dicari
         if (control.Tag != null && control.Tag.Equals(nama)) return control;

         foreach (Control ctl in control.Controls)
         {
            Control found = FindControl(ctl, nama);
            if (found != null) return found;
         }

         // Jka tidak ada yang ditemukan
         return null;
      }

      /// <summary>
      /// Method untuk mengecek jika Property Control terdapat data yang ingin dicari
      /// </summary>
      /// <param name="control">Control target</param>
      /// <param name="propertyName">Property name</param>
      /// <param name="data">Data yang ingin dicari</param>
      /// <returns>Mengembalikan true jika ditemukan, sebaliknya false</returns>
      public static bool PropertyValueEquals(this object control, string propertyName, string data)
      {
         // Ambil Property sesuai dengan property name dari object control
         var propertyInfo = control.GetType().GetProperty(propertyName);

         if (propertyInfo == null) // Property tidak ditemukan
            return false;

         // Cek jika Property memiliki value
         if (propertyInfo.GetValue(control, null) != null)
         {
            // Ambil value dari Property
            var value = propertyInfo.GetValue(control, null);

            // True jika data property value sama dengan data yang ingin dicari
            if (value.ToString().Equals(data))
               return true;
         }
         
         return false;
      }

      /// <summary>
      /// Enable control yang ingin dilewati / tidak termasuk dalam daftar Role detail
      /// </summary>
      /// <param name="control">Control target</param>
      /// <returns>Mengembalikan true jika control mempunyai Tag ignore</returns>
      public static bool TagIgnore(this object control)
      {
         return control.PropertyValueEquals("Tag", "ignore");
      }


      #region Reference https://stackoverflow.com/questions/297526/what-is-the-best-way-to-clear-all-controls-on-a-form-c?answertab=votes#tab-top

      private static Dictionary<Type, Action<Control>> controlDefaults = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(ComboBox), c => ((ComboBox)c).SelectedIndex = -1},
            {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
            {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
            {typeof(RadioButton), c => ((RadioButton)c).Checked = false}
      };

      private static void FindAndInvoke(Type type, Control control)
      {
         if (controlDefaults.ContainsKey(type))
         {
            controlDefaults[type].Invoke(control);
         }
      }

      public static void ClearControls(this Control.ControlCollection controls)
      {
         foreach (Control control in controls)
         {
            FindAndInvoke(control.GetType(), control);

            // Recrusive method
            control.Controls.ClearControls();
         }
      }

      public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
      {
         if (!controlDefaults.ContainsKey(typeof(T))) return;

         foreach (Control control in controls)
         {
            if (control.GetType().Equals(typeof(T)))
            {
               FindAndInvoke(typeof(T), control);
            }
         }
      }

      #endregion

      ///// <summary>
      ///// Method untuk mengecek jika string terdapat data yang ingin dicari
      ///// </summary>
      ///// <param name="text">Text target</param>
      ///// <param name="data">Data yang ingin dicari</param>
      ///// <param name="stringComparison">StringComparison enum</param>
      ///// <returns>Mengembalikan true jika ditemukan, sebaliknya false</returns>
      //public static bool Contains(this string text, string data,
      //  StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
      //{
      //   return text.IndexOf(data, stringComparison) >= 0;
      //}

      ///// <summary>
      ///// Mengubah color menjadi string
      ///// </summary>
      ///// <param name="color">Color target</param>
      ///// <returns>Mengembalikan string color RGB</returns>
      //public static string ToStringRgb(this Color color)
      //{
      //   return $"{color.R},{color.G},{color.B}";
      //}
   }
}
