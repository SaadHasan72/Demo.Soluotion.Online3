using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DtOs
{
    public class DepartmentDetailsDto
    {
        //public DepartmentDetailsDto(Department dept)
        //{
        //    deptId = dept.Id;
        //    Name = dept.Name;
        //    code = dept.Code;
        //    CreatedBy = dept.CreaedBy;
        //    LastModifiedBy = dept.LastModifiedBy;
        //    IsDeleted = dept.IsDeleted;
        //    DateOFCreation = DateOnly.FromDateTime(dept.CreatedOn);
        //    LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn);
        //}
        public int deptId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string code { get; set; }
        public DateOnly DateOFCreation { get; set; }
        public DateOnly LastModifiedOn { get; set; }


        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
