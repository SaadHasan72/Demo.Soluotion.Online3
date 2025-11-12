using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DtOs
{
    public class CreatedDepartmentDto
    {
        public string name {  get; set; }
        public string code { get; set; }
        public string? description { get; set; }
        public DateOnly DateOfCreation { get; set; }

    }
}
