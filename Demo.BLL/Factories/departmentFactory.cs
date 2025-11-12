using Demo.BLL.DtOs;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Factories
{
    static  class departmentFactory
    {

        public static DepartmentDTO ToDepartmentDTO (this Department d)
        {
            return new DepartmentDTO()
            {
                deptId = d.Id,
                Name = d.Name,
                code = d.Code,
                Description = d.description,
                DateOFCreation = DateOnly.FromDateTime(d.CreatedOn)
            };
        }
        public static DepartmentDetailsDto ToDepartmentDetailsDTO (this Department dept )
        {
            return new DepartmentDetailsDto()
            {
                deptId = dept.Id,
                Name = dept.Name,
                code = dept.Code,
                CreatedBy = dept.CreaedBy,
                LastModifiedBy = dept.LastModifiedBy,
                IsDeleted = dept.IsDeleted,
                DateOFCreation = DateOnly.FromDateTime(dept.CreatedOn),
                LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn),
            };
        }



        public static Department ToEntity(this CreatedDepartmentDto dto)
        {
            return new Department()
            {
                Name = dto.name,
                Code = dto.code,
                description = dto.description,
                CreatedOn = dto.DateOfCreation.ToDateTime(new TimeOnly())


            };
        
        }
        public static Department ToEntity(this UpdatedDepartmentsDto dto)
        {
            return new Department()
            {
                Id = dto.Id,
                Name = dto.name,
                Code = dto.code,
                description = dto.description,
                CreatedOn = dto.DateOfCreation.ToDateTime(new TimeOnly())


            };
        
        }
        


    }
}
