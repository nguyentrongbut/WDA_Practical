namespace HR.Application.DTOs
{
    public class DepartmentCreateDto
    {
        public string DepartmentName { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int NumberOfPersonals { get; set; } = 0;
    }

    public class DepartmentEditDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int NumberOfPersonals { get; set; } = 0;
    }
}