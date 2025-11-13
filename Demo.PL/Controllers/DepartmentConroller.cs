using Demo.BLL;
using Demo.BLL.DtOs;
using Demo.PL.ViewModels.DepartmentViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Demo.PL.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService ,
                                      ILogger<HomeController> _logger,
                                      IWebHostEnvironment _environment) :Controller
    {
        private readonly IDepartmentService departmentService = _departmentService;
        private readonly ILogger<HomeController> logger = _logger;
        private readonly IWebHostEnvironment environment = _environment;

        [HttpGet]

        public IActionResult Index() 
        {
            var departments = departmentService.GetAllDepartments();
            return View(departments);
        }



        #region Create
        [HttpGet]
        public IActionResult Create ()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatedDepartmentDto departmentDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int result =departmentService.AddDepartment(departmentDto);
                    if (result > 0) return RedirectToAction(nameof(Index));
                    else 
                    {
                        ModelState.AddModelError(string.Empty, "Department Can't be Add");
                        return View(departmentDto);
                    }
                }
                catch (Exception ex) 
                {
                    //Log Exception 
                    if (_environment.IsDevelopment()) 
                    {
                    ModelState.AddModelError(string.Empty,ex.Message);
                        return View(departmentDto);
                    }
                    else
                    {
                    return View (departmentDto);
                    }
                }
            }
            else return View(departmentDto);
        }
        #endregion

        #region Details

        [HttpGet]
        public IActionResult Details(int?id)
        {
            if (!id.HasValue) return BadRequest();
            var department = _departmentService.GetById(id.Value);

            if (department is null) return NotFound(); 
            return View(department);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int ?id)
        {

            if (!id.HasValue)return BadRequest();
            var department = _departmentService.GetById(id.Value);
            if (department is null) return NotFound();
            var deptViewModel = new DepartmentEditViewModel()
            {

                name = department.Name,
                code = department.code,
                description = department.Description,
                DateOfCreation = department.DateOFCreation
            };
            return View(deptViewModel);


        }


        [HttpPost]
        public IActionResult Edit ([FromRoute]int id,DepartmentEditViewModel viewModel) 
        {
            if (!ModelState.IsValid) return View(viewModel);
            try
            {
                var updateDeptDto = new UpdatedDepartmentsDto()
                {
                    Id=id,
                    code = viewModel.code,
                    name=viewModel.name,
                    description=viewModel.description,
                    DateOfCreation=viewModel.DateOfCreation

                };
              var res=  _departmentService.UpdateDepartment(updateDeptDto);
                if (res>0) return RedirectToAction(nameof(Index));
                return View(viewModel);
            }
            catch (Exception ex)
            {
                if (_environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View(viewModel);
                }
                else
                {
                    return View(viewModel);
                }
            }
        
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int ? id) 
        {
            if (!id.HasValue) return BadRequest();
            var dept =_departmentService.GetById(id.Value);
            if (dept is null) return NotFound();
             return View(dept);
        }

        [HttpPost]
        public IActionResult Delete(int  id) 
        {
            if (id == 0) return BadRequest();
            try 
            {
                bool isDeleted = _departmentService.DeleteDepartment(id);
                if (isDeleted) return RedirectToAction(nameof(Index));
                else ModelState.AddModelError(string.Empty, "Department can't Be Deleted");
                return RedirectToAction(nameof(Delete), new { id });
            }
            catch (Exception ex)
            {
                if (_environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View("ErrorView",ex);
                }
            }

            //if (!id.HasValue) return BadRequest();
            //var dept =_departmentService.GetById(id.Value);
            //if (dept is null) return NotFound();
            // return View(dept);
        }
        #endregion
    }
}
