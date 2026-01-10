namespace HR.Application.DTOs
{
    public class EmployeeCreateDto
    {
        public string EmployeeName { get; set; } = null!;
        public string EmployeeCode { get; set; } = null!;
        public string Rank { get; set; } = null!;
        public int DepartmentId { get; set; }
    }

    public class EmployeeEditDto
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string EmployeeCode { get; set; } = null!;
        public string Rank { get; set; } = null!;
        public int DepartmentId { get; set; }
    }
}