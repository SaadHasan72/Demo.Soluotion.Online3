using Demo.BLL.DtOs;
using System.Collections.Generic;

namespace Demo.BLL
{
    public interface IDepartmentService
    {
        int AddDepartment(CreatedDepartmentDto departmentDto);           // Add a department
        bool DeleteDepartment(int id);                                   // Delete by ID
        IEnumerable<DepartmentDTO> GetAllDepartments();                 // Fixed typo: GetAllaDepartments → GetAllDepartments
        DepartmentDetailsDto? GetById(int id);                           // Get by ID
        int UpdateDepartment(UpdatedDepartmentsDto departmentDto);       // Renamed UpdateDepartmentDto → UpdateDepartment
    }
}
