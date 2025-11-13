namespace Demo.PL.ViewModels.DepartmentViewModels
{
    public class DepartmentEditViewModel
    {
        public string name { get; set; }=string.Empty;
        public string code { get; set; } = string.Empty;
        public string? description { get; set; }
        public DateOnly DateOfCreation { get; set; }
    }
}
