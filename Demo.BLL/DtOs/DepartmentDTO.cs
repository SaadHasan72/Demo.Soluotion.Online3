using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DtOs
{
    public class DepartmentDTO
    {

      public int deptId {  get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
     public string code { get; set; }
        public DateOnly DateOFCreation { get; set; }

    }
}
