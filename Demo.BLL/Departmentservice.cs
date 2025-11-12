
using Demo.BLL.DtOs;
using Demo.BLL.Factories;
using Demo.DAL.Models;
using Demo.DAL.Repositiories;

namespace Demo.BLL
{
    public class DepartmentService(IDepartmentRepo _Departmentrepository) : IDepartmentService
    {
        //public Department? GetById(int id) 
        //{

        //_repository.GetById(id);
        //}
        public IEnumerable<DepartmentDTO> GetAllDepartments()
        {
            var depts = _Departmentrepository.GetAll();
            var departmentsToReturn = depts.Select(d => d.ToDepartmentDTO());//EX method
            return departmentsToReturn;
        }

        public DepartmentDetailsDto? GetById(int id)
        {
            var dept = _Departmentrepository.GetById(id);

            //if (dept is null) return null;
            //else
            //{
            //    var deptToReturn = new DepartmentDetailsDto()
            //    {
            //        deptId = dept.Id,
            //        Name = dept.Name,
            //        code = dept.Code,
            //        CreatedBy = dept.CreaedBy,
            //        LastModifiedBy = dept.LastModifiedBy,
            //        IsDeleted = dept.IsDeleted,
            //        DateOFCreation = DateOnly.FromDateTime(dept.CreatedOn),
            //        LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn)

            //    };
            //    return deptToReturn;
            //return dept is null ? null : new DepartmentDetailsDto (dept); //Contructor mapping 
            return dept is null ? null : dept.ToDepartmentDetailsDTO(); //Extantion mapping 

        }


        public int AddDepartment(CreatedDepartmentDto DepartmentDto)
        {
            var entity = DepartmentDto.ToEntity();
            return _Departmentrepository.Add(entity);
        }



        public int UpdateDepartment(UpdatedDepartmentsDto DepartmentDto)
        {
            return _Departmentrepository.Update(DepartmentDto.ToEntity());
        }

        public bool DeleteDepartment(int id)
        {
            var department = _Departmentrepository.GetById(id);
            if (department is null) return false;
            else
            {
                var res = _Departmentrepository.Delete(department);
                if (res > 0) return true;
                else return false;


            }
        }

   
      
    }
}
