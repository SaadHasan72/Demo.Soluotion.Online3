using Demo.BLL;
using Microsoft.AspNetCore.Mvc;
using Demo.BLL.DtOs;


namespace Demo.PL.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService):Controller
    {
        [HttpGet]

        public IActionResult Index() 

        {
            var departments = _departmentService.GetAllDepartments();
            return View(departments);
        }
    }
}
