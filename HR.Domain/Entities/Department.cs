using System.ComponentModel.DataAnnotations;

namespace HR.Domain.Entities;

public class Department
{
    public int Id { get; set; }

    [Required]
    public string DepartmentName { get; set; }

    [Required]
    public string DepartmentCode { get; set; }

    public string Location { get; set; }
    public int NumberOfPersonals { get; set; }

    public ICollection<Employee> Employees { get; set; }
}