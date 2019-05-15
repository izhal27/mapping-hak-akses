using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Dp = Dapper.Contrib.Extensions;

namespace MappingHakAkses.Model
{
   [Dp.Table("operator")]
   public class Operator
   {
      [Browsable(false)]
      [Dp.Key]
      [DisplayName("ID")]
      public int id { get; set; }
      [MaxLength(100)]
      [DisplayName("Nama")]
      public string nama { get; set; }
      [MaxLength(150)]
      [DisplayName("Alamat")]
      public string alamat { get; set; }
      [MaxLength(50)]
      [DisplayName("HP")]
      public string hp { get; set; }
      [MaxLength(100)]
      [DisplayName("Login ID")]
      public string login_id { get; set; }
      [Browsable(false)]
      [MaxLength(50)]
      [DisplayName("Password")]
      public string password { get; set; }
      [Browsable(false)]
      [MaxLength(50)]      
      [Dp.Write(false)]
      [DisplayName("Konfirmasi Password")]
      public string konf_password { get; set; }
      [Browsable(false)]
      [MaxLength(20)]
      public string role_kode { get; set; }
      [DisplayName("Role")]
      [Dp.Write(false)]      
      public string role_nama { get; set; }
      [DisplayName("Password Sekarang")]
      [Browsable(false)]
      [MaxLength(50)]      
      [Dp.Write(false)]
      public string current_password { get; set; }
      [Browsable(false)]
      [MaxLength(50)]      
      [Dp.Write(false)]
      public string current_hashed { get; set; }

      public void SetPropertyValue(string nama, string alamat
         , string hp, string login_id
         , string password, string konf_password
         , string role_kode)
      {
         this.nama = nama;
         this.alamat = alamat;
         this.hp = hp;
         this.login_id = login_id;
         this.password = password;
         this.konf_password = konf_password;
         this.role_kode = role_kode;
      }
   }   
}
