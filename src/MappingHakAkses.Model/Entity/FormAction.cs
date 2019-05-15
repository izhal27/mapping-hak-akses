using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Dp = Dapper.Contrib.Extensions;

namespace MappingHakAkses.Model
{
   [Dp.Table("form_action")]
   public class FormAction
   {
      [MaxLength(100)]
      public string form_name { get; set; }
      [MaxLength(100)]
      public string form_text { get; set; }
      [MaxLength(50)]
      public string act_1 { get; set; }
      [MaxLength(50)]
      public string act_2 { get; set; }
      [MaxLength(50)]
      public string act_3 { get; set; }
      [MaxLength(50)]
      public string act_4 { get; set; }
      [MaxLength(50)]
      public string act_5 { get; set; }
      [MaxLength(50)]
      public string act_6 { get; set; }
      [MaxLength(50)]
      public string act_7 { get; set; }
      [MaxLength(50)]
      public string act_8 { get; set; }
      [MaxLength(50)]
      public string act_9 { get; set; }
      [MaxLength(50)]
      public string act_10 { get; set; }
      [MaxLength(50)]
      public string act_11 { get; set; }
      [MaxLength(50)]
      public string act_12 { get; set; }
      [MaxLength(50)]
      public string act_13 { get; set; }
      [MaxLength(50)]
      public string act_14 { get; set; }
      [MaxLength(50)]
      public string act_15 { get; set; }
   }
}
