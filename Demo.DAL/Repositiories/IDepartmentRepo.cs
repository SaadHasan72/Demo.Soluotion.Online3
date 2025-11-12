
namespace Demo.DAL.Repositiories
{
    public interface IDepartmentRepo
    {
        int Add(Department department);
        int Delete(Department department);
        IEnumerable<Department> GetAll(bool withTracking = false);
        Department? GetById(int id);
        int Update(Department department);
    }
}