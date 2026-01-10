using HR.Domain.Entities;

namespace HR.Application.Interfaces;

public interface IDepartmentRepository
{
    Task<List<Department>> GetAllAsync();
    Task<Department?> GetByIdAsync(int id);
    Task AddAsync(Department department);
    Task UpdateAsync(Department department);
    Task DeleteAsync(int id);

    Task<int> CountEmployeeAsync(int departmentId);
}