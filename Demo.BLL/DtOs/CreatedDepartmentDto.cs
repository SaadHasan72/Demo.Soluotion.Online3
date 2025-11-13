using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DtOs
{
    public class CreatedDepartmentDto
    {
        [MaxLength (10)]
        public string name {  get; set; }
        public string code { get; set; }
        public string? description { get; set; }
        public DateOnly DateOfCreation { get; set; }

    }
}
