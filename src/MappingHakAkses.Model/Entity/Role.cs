using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Dp = Dapper.Contrib.Extensions;

namespace MappingHakAkses.Model
{
   [Dp.Table("role")]
   public class Role : BaseEntity
   {
      [Dp.Key]
      [Browsable(false)]
      [DisplayName("ID")]
      public int id { get; set; }
      [MaxLength(20)]
      [DisplayName("Kode")]
      public string kode { get; set; }
      [MaxLength(50)]
      [DisplayName("Nama")]
      public string nama { get; set; }
      [MaxLength(150)]
      [DisplayName("Keterangan")]
      public string keterangan { get; set; }

      public void SetPropertyValue(string kode, string nama
         , string keterangan, int created_by)
      {
         this.kode = kode;
         this.nama = nama;
         this.keterangan = keterangan;
         this.created_by = created_by;
      }
   }
}
