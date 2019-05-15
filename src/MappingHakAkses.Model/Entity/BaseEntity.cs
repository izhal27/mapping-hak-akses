using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Model
{
   public class BaseEntity
   {
      [Browsable(false)]
      public int created_by { get; set; }
   }
}
