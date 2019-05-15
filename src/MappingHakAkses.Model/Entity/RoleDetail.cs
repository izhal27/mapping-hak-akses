using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Dp = Dapper.Contrib.Extensions;

namespace MappingHakAkses.Model
{
   [Dp.Table("role_detail")]
   public class RoleDetail
   {
      public string role_kode { get; set; }
      public string menu_name { get; set; }
      public string menu_parent { get; set; }
      public string form_action { get; set; }
      public string tag { get; set; }

      public void SetPropertyValue(string role_kode, string menu_name
         ,string menu_parent, string form_action, string tag)
      {
         this.role_kode = role_kode;
         this.menu_name = menu_name;
         this.menu_parent = menu_parent;
         this.form_action = form_action;
         this.tag = tag;
      }
   }
}
